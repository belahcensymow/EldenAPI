using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MaterialEx
	{
		private readonly PARAM _param;
		public MaterialEx(PARAM param) => _param = param;
		public IEnumerable<MaterialExRow> Entries => _param.Rows.Select(r => new MaterialExRow(r));
	}
	public class MaterialExRow
	{
		private readonly PARAM.Row _row;
		public MaterialExRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public string paramName => (string)_row["paramName"].Value;
		public int materialId => (int)_row["materialId"].Value;
		public float materialParamValue0 => (float)_row["materialParamValue0"].Value;
		public float materialParamValue1 => (float)_row["materialParamValue1"].Value;
		public float materialParamValue2 => (float)_row["materialParamValue2"].Value;
		public float materialParamValue3 => (float)_row["materialParamValue3"].Value;
		public float materialParamValue4 => (float)_row["materialParamValue4"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | paramName: {paramName} | materialId: {materialId} | materialParamValue0: {materialParamValue0} | materialParamValue1: {materialParamValue1} | materialParamValue2: {materialParamValue2} | materialParamValue3: {materialParamValue3} | materialParamValue4: {materialParamValue4}";
	}
}
