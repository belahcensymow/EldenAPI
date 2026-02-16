using System.Runtime.CompilerServices;
using System.Text;
using EldenAPI;
using SoulsFormats;
using SoulsFormats.Cryptography;

namespace EldenRingDataExtractor
{
	/// <summary>
	/// Start by getting files then get file by ID or Name finally get file info
	///	GetFiles() -> GetFile(ID/Name) -> GetInfo(GetFile())
	/// </summary>
	public partial class RegulationHandler
	{
		public class RegulationMetadata : ResourceMetadata {}
		private readonly string _path;
		private readonly BND4 _regulation;
		private ConditionalWeakTable<PARAM, RegulationMetadata> _PARAMMetadata = new();
		public RegulationHandler(string gamePath)
		{
			_path = Path.Combine(gamePath, @"regulation.bin");
			_regulation = RegulationDecryptor.DecryptERRegulation(_path);
		}

		public List<BinderFile> GetFiles()
		{
            List<BinderFile> regulationFiles = [];

            foreach (var file in _regulation.Files)
            {
				if (!String.IsNullOrEmpty(file.Name))
				{
					regulationFiles.Add(file);
				}

            }
			return regulationFiles;
        }
		private PARAM GetFileHelper(BinderFile? file, string arg)
		{
            PARAM param = new PARAM();
            if (file is null)
            {
                Console.WriteLine($"PARAM wiht ID: {arg} was not found!");
                _PARAMMetadata.Add(param, new RegulationMetadata { });
                return param;
            }
            param = PARAM.Read(file.Bytes);
			string paramdefName = GetParamdefName(param);
			param.ApplyParamdef(new ParamDefHandler(paramdefName).GetPARAMDEF());
            _PARAMMetadata.Add(param, new RegulationMetadata { Name = file.Name, ID = file.ID });
            return param;
        }
		public PARAM GetFile(int ID)
		{
			return GetFileHelper(_regulation.Files.FirstOrDefault(file => file.ID == ID), ID.ToString());
		}
		public PARAM GetFile(string Name)
		{
			return GetFileHelper(_regulation.Files.FirstOrDefault(file => file.Name.Contains(Name)), Name);
		}
		public PARAM GetFile(BinderFile file)
		{
			return GetFile(file.Name);
		}

		public RegulationMetadata GetInfo(PARAM param)
		{
			if(_PARAMMetadata.TryGetValue(param, out RegulationMetadata? regulationMetadata))
			{
				return regulationMetadata;
			}
			else
			{
                Console.WriteLine($"PARAM not found!");
				return new RegulationMetadata { };
            }
        }

		public string GetParamdefName(PARAM param)
		{
			Dictionary<string, string> manualPatches = new() 
			{
			{ "Geometory", "Geometry"},
			{ "Cacl", "Calc"},
			{ "CharacterInitParam", "CharaInitParam"},
			{ "GraphicsConfigParam", "GraphicsConfig"},
			{ "MapGdRegionIdParam", "MapGdRegionInfo"},
			{ "MapGridCreateHeightLimitDetailInfoParam", "MapGridCreateHeightDetailLimitInfo"},
			{ "MapGridCreateHeightLimitInfoParam", "MapGridCreateHeightLimitInfo"},
			{ "MaterialExParam", "MaterialEx"},
			{ "MenupropertyLayout", "MenuPropertyLayoutParam"},
			{ "MenupropertySpec", "MenuPropertySpecParam"},
			{ "MenuValueTableSpec", "MenuValueTableSpecParam"},
			{ "PostureControlParam", "PostureControlParam_"},
			{ "SpeedtreeModelParam", "SpeedtreeModel"},
			{ "SpEffectParam", "SpEffectSetParam"},
			{ "SpEffectVfxParam", "SpEffectVfx"},
			{ "WwiseValueToStrConvertParam", "WwiseValueToStrConvertParamFormat"}
			};

            string paramdefName = "";
            if (!string.IsNullOrEmpty(param.ParamType))
            {
                paramdefName = param.ParamType;
				paramdefName = string.Concat(paramdefName.Split("_").Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower())) + ".xml";
                foreach (var patch in manualPatches)
					paramdefName = paramdefName.Replace(patch.Key, patch.Value);
					
                if (paramdefName.StartsWith("Cs")) paramdefName = paramdefName.Replace("Cs", "");
                if (paramdefName.EndsWith("StDlc02.xml")) paramdefName = paramdefName.Replace("StDlc02.xml", ".xml");
                else if (paramdefName.EndsWith("St.xml")) paramdefName = paramdefName.Replace("St.xml", ".xml");
                //Console.WriteLine(paramdefName);
            }
			return paramdefName;
        }
		public string GetParamdefName(string file)
		{
			return GetParamdefName(GetFile(file));
		}
		public string GetParamdefName(int ID)
		{
			return GetParamdefName(GetFile(ID));
		}
		public string GetParamdefName(BinderFile file)
		{
			return GetParamdefName(file.Name);
		}

        public void GenerateParamClasses()
        {
            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            while (directory.GetFiles("*.csproj").Length == 0)
            {
                if (directory.Parent is null) break;
                directory = directory.Parent;
            }
            string outputDir = directory?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;
            outputDir = Path.Combine(outputDir, "Generated");
			Directory.CreateDirectory(outputDir);
            StringBuilder partialClassText = new();
            partialClassText.AppendLine("namespace EldenRingDataExtractor\r\n{");
            partialClassText.AppendLine("\tpublic partial class RegulationHandler\r\n\t{");
            HashSet<string> classesList = [];
            //HashSet<string> typesList = [];
            foreach (var file in GetFiles())
            {
                PARAM param = GetFile(file.Name);
                string className = GetParamdefName(param).Replace(".xml", "");
                //if (!className.Contains("BonfireWarpParam")) continue;
				if (!classesList.Add(className)) continue;

                partialClassText.AppendLine($"\t\tprivate {className} _{className};");
                partialClassText.AppendLine($"\t\tpublic {className} {className} => _{className} ??= new {className}(GetFile(@\"{file.Name}\"));");
                StringBuilder toStringText = new();
                toStringText.Append("\t\tpublic override string ToString() => $\"ID: {ID} | Name: {Name}");

                StringBuilder classText = new();
                classText.AppendLine("using System.Collections.Generic;");
                classText.AppendLine("using System.Linq;");
                classText.AppendLine("using SoulsFormats;");
                classText.AppendLine("\r\nnamespace EldenRingDataExtractor\r\n{");
                classText.AppendLine($"\tpublic class {className}");
                classText.AppendLine("\t{");
                classText.AppendLine("\t\tprivate readonly PARAM _param;");
                classText.AppendLine($"\t\tpublic {className}(PARAM param) => _param = param;");
                classText.AppendLine($"\t\tpublic IEnumerable<{className}Row> Entries => _param.Rows.Select(r => new {className}Row(r));");
                classText.AppendLine("\t}");
                classText.AppendLine($"\tpublic class {className}Row");
                classText.AppendLine("\t{");
                classText.AppendLine("\t\tprivate readonly PARAM.Row _row;");
                classText.AppendLine($"\t\tpublic {className}Row(PARAM.Row row) => _row = row;");
                classText.AppendLine("\t\tpublic int ID => _row.ID;");
                classText.AppendLine("\t\tpublic string Name => _row.Name;");
                HashSet<string> cellsNames = [];
                foreach (var cell in param.Rows[0].Cells)
                {
                    string propertyName = cell.Def.InternalName;
                    //typesList.Add(MapType(cell.Def.InternalType));
					if (!cellsNames.Add(propertyName)) continue;
                    string csharpType = MapType(cell.Def.InternalType);
                    if (csharpType != "byte[]") toStringText.Append($" | {propertyName}: {{{propertyName}}}");
                    classText.AppendLine($"\t\tpublic {csharpType} {propertyName} => ({csharpType})_row[\"{propertyName}\"].Value;");
                }
                toStringText.Append("\";");
                classText.AppendLine(toStringText.ToString());
                classText.AppendLine("\t}");
                classText.AppendLine("}");
                File.WriteAllText(Path.Combine(outputDir, $"{className}.cs"), classText.ToString());
            }
            //foreach (var t in typesList) Console.WriteLine(t);
            partialClassText.AppendLine("\t}");
            partialClassText.AppendLine("}");
            File.WriteAllText(Path.Combine(outputDir, "RegulationHandler.Generated.cs"), partialClassText.ToString());
            Console.WriteLine(outputDir);
        }

        public static string MapType(string xmlType)
        {
            string type = xmlType.Trim();
            string lowerType = type.ToLower();
            switch (lowerType)
            {
                case "s8": return "sbyte";
                case "u8": return "byte";
                case "s16": return "short";
                case "u16": return "ushort";
                case "s32": return "int";
                case "u32": return "uint";
                case "b32": return "int";
                case "f32": return "float";
                case "angle32": return "float";
                case "f64": return "double";
                case "dummy8": return "byte[]";
                case "fixstr": return "string";
                case "fixstrw": return "string";
                case "SOUND_BGM_MAP_PLACE_TYPE": return "Int16";
            }
            bool isEnum = !type.Any(char.IsLower) || type.Contains('_');
            if (isEnum) return "byte";
            return "byte[]";
        }



    }
}