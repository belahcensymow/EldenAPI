using System.Runtime.CompilerServices;
using SoulsFormats;

namespace EldenAPI
{
    public enum BNDType
    {
        ITEM,
        MENU,
        ITEMDLC1,
        MENUDLC1,
        ITEMDLC2,
        MENUDLC2,
    };
    public class ResourceMetadata
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; } = "Unknown";
        public override string ToString()
        {
            var values = GetType().GetProperties().Select(property => $"{property.Name}: {property.GetValue(this)}");
            return string.Join(" | ", values);
        }
    }

    public class MSGBNDHandler
    {
        private readonly string _path;
        private readonly BND4 _item = new();
        private readonly BND4 _menu = new();
        private readonly BND4 _itemDLC1 = new();
        private readonly BND4 _menuDLC1 = new();
        private readonly BND4 _itemDLC2 = new();
        private readonly BND4 _menuDLC2 = new();
        public class FMGMetadata : ResourceMetadata { 
            public BNDType bndType { get; set; } = BNDType.MENU;
            internal Dictionary<int, string> _textCache = [];
        }
        private readonly ConditionalWeakTable<FMG, FMGMetadata> _FMGTable = [];
        //public List<Dictionary<int, string>> _textCache = [];
        public MSGBNDHandler(string gamePath)
        {
            _path = Path.Combine(gamePath, @"msg", @"engus");
            byte[] itemData = DCX.Decompress(Path.Combine(_path, @"item.msgbnd.dcx"));
            byte[] menuData = DCX.Decompress(Path.Combine(_path, @"menu.msgbnd.dcx"));
            byte[] itemDLC1Data = DCX.Decompress(Path.Combine(_path, @"item_dlc01.msgbnd.dcx"));
            byte[] menuDLC1Data = DCX.Decompress(Path.Combine(_path, @"menu_dlc01.msgbnd.dcx"));
            byte[] itemDLC2Data = DCX.Decompress(Path.Combine(_path, @"item_dlc02.msgbnd.dcx"));
            byte[] menuDLC2Data = DCX.Decompress(Path.Combine(_path, @"menu_dlc02.msgbnd.dcx"));
            _item = BND4.Read(itemData);
            _menu = BND4.Read(menuData);
            _itemDLC1 = BND4.Read(itemDLC1Data);
            _menuDLC1 = BND4.Read(menuDLC1Data);
            _itemDLC2 = BND4.Read(itemDLC2Data);
            _menuDLC2 = BND4.Read(menuDLC2Data);
        }

        public List<BinderFile> GetFiles(BNDType bndType)
        {
            BND4 bnd = bndType switch
            {
                BNDType.MENU => _menu,
                BNDType.ITEM => _item,
                BNDType.ITEMDLC1 => _itemDLC1,
                BNDType.MENUDLC1 => _menuDLC1,
                BNDType.ITEMDLC2 => _itemDLC2,
                BNDType.MENUDLC2 => _menuDLC2,
                _ => _item
            };
            List<BinderFile> files = [];
            foreach (var file in bnd.Files) files.Add(file);
            return files;
        }

        public FMG GetFMG(BNDType bndType, int ID)
        {
            var existing = _FMGTable.FirstOrDefault(x => x.Value.ID == ID && x.Value.bndType == bndType);
            if (existing.Key is not null) return existing.Key;
            FMG fmg = new();
            var file = GetFiles(bndType).FirstOrDefault(file => file.ID == ID);
            Dictionary<int, string> textCache = [];
            if (file is null)
            {
                Console.WriteLine($"FMG wiht ID: {ID} was not found!");
                _FMGTable.Add(fmg, new FMGMetadata { bndType = bndType, ID = ID});
                return fmg;
            }
            fmg = FMG.Read(file.Bytes);
            foreach (var entry in fmg.Entries)
            {
                if (entry.ID == -1 || string.IsNullOrEmpty(entry.Text)) continue;
                textCache.Add(entry.ID, entry.Text);
            }
            _FMGTable.Add(fmg, new FMGMetadata { Name = file.Name, ID = file.ID, bndType = bndType, _textCache = textCache });
            return fmg;
        }

        public FMG GetFMG(BNDType bndType, string Name)
        {
            BinderFile file;
            int ID = -1;
            foreach (var f in GetFiles(bndType))
            {
                if (f.Name.Contains(Name, StringComparison.OrdinalIgnoreCase))
                { 
                    ID = f.ID;
                    file = f;
                    break;
                }
            }
            return GetFMG(bndType, ID);
        }

        public FMGMetadata GetInfo(FMG fmg)
        {
            if(_FMGTable.TryGetValue(fmg, out FMGMetadata? fmgMetadata))
            {
                return fmgMetadata;
            }
            else
            {
                Console.WriteLine($"FMG not found!\nYou must use the GetFile() function for this function to work.");
                return new FMGMetadata { };
            }
        }

        public string TextIdToText(FMG fmg, int ID)
        {
            var metadata = GetInfo(fmg);
            if(metadata.ID == -1)
            {
                foreach (var entry in fmg.Entries) if (entry.ID == ID) return entry.Text;
                return $"Unknown ID: {ID}";
            }
            //return metadata._textCache.TryGetValue(ID, out var text) ? text : $"Unknown ID: {ID}";
            return metadata._textCache.TryGetValue(ID, out var text) ? text : $"{ID}";
        }

        public string TextIdToText(List<FMG> fmgs, int ID)
        {
            string idString = ID.ToString();
            foreach(FMG fmg in fmgs)
            {
                string result = TextIdToText(fmg, ID);
                if (result != "-1" && result != idString) return result;
            }
            return $"{ID}";
        }

        public string TextIdToText(FMG fmg, string ID)
        {
            return TextIdToText(fmg, int.Parse(ID));
        }

        public List<int> TextToTextId(FMG fmg, string Text)
        {
            List<int> idList = [];
            foreach (var entry in fmg.Entries) if (entry.Text == Text) idList.Add(entry.ID);
            return [-1];
        }
    }
}