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
        private BND4 _item = new();
        private BND4 _menu = new();
        private BND4 _itemDLC1 = new();
        private BND4 _menuDLC1 = new();
        private BND4 _itemDLC2 = new();
        private BND4 _menuDLC2 = new();
        public class FMGMetadata : ResourceMetadata { public BNDType bndType { get; set; } = BNDType.MENU; }
        private readonly ConditionalWeakTable<FMG, FMGMetadata> _FMGTable = new();
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
            FMG fmg = new FMG();
            var file = GetFiles(bndType).FirstOrDefault(file => file.ID == ID);
            if (file is null)
            {
                Console.WriteLine($"FMG wiht ID: {ID} was not found!");
                _FMGTable.Add(fmg, new FMGMetadata { bndType = bndType });
                return fmg;
            }
            fmg = FMG.Read(file.Bytes);
            _FMGTable.Add(fmg, new FMGMetadata { Name = file.Name, ID = file.ID, bndType = bndType });
            return fmg;
        }

        public FMG GetFMG(BNDType bndType, string Name)
        {
            FMG fmg = new FMG();
            var file = GetFiles(bndType).FirstOrDefault(file => file.Name.Contains(Name));
            if (file is null)
            {
                Console.WriteLine($"FMG wiht Name: {Name} was not found!");
                _FMGTable.Add(fmg, new FMGMetadata { bndType = bndType });
                return fmg;
            }
            fmg = FMG.Read(file.Bytes);
            _FMGTable.Add(fmg, new FMGMetadata { Name = file.Name, ID = file.ID, bndType = bndType });
            return fmg;
        }

        public FMGMetadata GetInfo(FMG fmg)
        {
            if(_FMGTable.TryGetValue(fmg, out FMGMetadata? fmgMetadata))
            {
                return fmgMetadata;
            }
            else
            {
                Console.WriteLine($"FMG not found!");
                return new FMGMetadata { };
            }
        }
    }
}