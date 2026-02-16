using System.Reflection;
using EldenRingDataExtractor;
using SoulsFormats;

namespace EldenAPI
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string gameDir = @"C:\Games\ELDEN RING\Game\";
            MSGBNDHandler msgbndHandler = new(gameDir);
            RegulationHandler regulation = new(gameDir);


            //var entries = regulation.BonfireWarpParam.Entries;
            //FMG fmg = msgbndHandler.GetFMG(BNDType.ITEMDLC2 , 18);
            /*foreach (var entry in entries)
            {
                Console.WriteLine($"" +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId1)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId2)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId3)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId4)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId5)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId6)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId7)} | " +
                    $"{msgbndHandler.TextIdToText(fmg, entry.textId8)}");
            }*/
            //foreach (var file in msgbndHandler.GetFiles(BNDType.MENUDLC2)) Console.WriteLine(file);



            var subcategoryParam = regulation.BonfireWarpSubCategoryParam.Entries;
            var categoryParam = regulation.BonfireWarpTabParam.Entries;
            var sitesOfGrace = regulation.BonfireWarpParam.Entries;
            FMG npcName = msgbndHandler.GetFMG(BNDType.ITEMDLC2, 18);
            FMG placeName = msgbndHandler.GetFMG(BNDType.ITEMDLC2, 19);
            FMG placeNameDLC1 = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "PlaceName_dlc01");
            FMG placeNameDLC2 = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "PlaceName_dlc02");
            FMG menuText = msgbndHandler.GetFMG(BNDType.MENUDLC2, "MenuText");
            HashSet<int> subCategoryIds = [];
            Dictionary<int, string> foundSubCategories = [];
            var regionNames = new Dictionary<int, string>
            {
                { 6800, "Gravesite Plain" },
                { 6900, "Scadu Altus" },
                { 10000, "Stormveil Castle" },
                { 11000, "Leyndell, Royal Capital" },
                { 11100, "Roundtable Hold" },
                { 12000, "Ainsel River" },
                { 12001, "Siofra River" },
                { 12002, "Deeproot Depths" },
                { 13000, "Crumbling Farum Azula" },
                { 14000, "Academy of Raya Lucaria" },
                { 15000, "Miquella's Haligtree" },
                { 16000, "Volcano Manor" },
                { 20000, "Land of the Tower" },
                { 21000, "Shadow Keep" },
                { 61000, "Limgrave" },
                { 62000, "Liurnia of the Lakes" },
                { 63000, "Altus Plateau" },
                { 64000, "Caelid" },
                { 65000, "Mountaintops of the Giants" }
            };

            foreach (var siteOfGrace in sitesOfGrace.ToList().OrderBy(s => s.bonfireSubCategoryId))
            {
                //if (siteOfGrace.iconId != 1)
                //Console.WriteLine(msgbndHandler.TextIdToText([placeName, placeNameDLC1], siteOfGrace.textId1));
                //if (landmark.iconId == 7)
                if (siteOfGrace.bonfireSubCategoryId == 0) continue;
                Console.WriteLine($"{siteOfGrace} : {msgbndHandler.TextIdToText([placeName, placeNameDLC1], siteOfGrace.textId1)}");
                Console.WriteLine();
                subCategoryIds.Add(siteOfGrace.bonfireSubCategoryId);
            }
            foreach (var id in subCategoryIds)
            {
                if (regionNames.TryGetValue(id, out string? text))
                {
                    foundSubCategories.Add(id, text);
                }
            }
            //int regionId = 0;
            //string subcategory = regionNames.TryGetValue(subcategoryParam.FirstOrDefault(subcategory => subcategory.ID == regionId).textId);
            foreach (var subcategory in subcategoryParam)
            {
                //Console.WriteLine($"{landmark} : {msgbndHandler.TextIdToText(menuText, landmark.textId)}");
            }

            /*
             * BonfireWarpParam
             * if (disableParam_NT  = 1) continue;
             * int ID               = siteOfGrace.ID;
             * string Name          = msgbndHandler.TextIdToText(placeText, siteOfGrace.ID);
             * int IconId           = siteOfGrace.IconID;
             * int regionId         = subcategory.
             * int subregionId
             * vector3 coordinates
             */



            //foreach (var found in foundSubCategories) Console.WriteLine(found);
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var original in subCategoryIds) Console.WriteLine(original);


            Type type = sitesOfGrace.ToList()[0].GetType();
            foreach (var property in type.GetProperties())
            {
                //Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
            }
            /*
            posX posY posZ : Coordinates
            textId1->8 : Name
            iconId : Icon sprite
            clearedEventFlagId : alternate icon color
            isAreaIcon : Icon scale makes icon bigger
            areaNo: 61 60 11 etc what are Limgrave and such
            gridXNo gridZNo : Xhorizontal Zvertical tile
            dispMinZoomStep : At what zoom level you start seeing it 0 for everything
             */









            //foreach (var file in msgbndHandler.GetFiles(BNDType.MENUDLC2))
            {
            //    FMG fmg = msgbndHandler.GetFMG(BNDType.MENUDLC2, file.ID);
            //    Console.WriteLine(msgbndHandler.TextIdToText(fmg, 120601), file.ID);
            }
            /*
            var allParams = regulation.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var paramSource in allParams)
            {
                // Get the Param instance (e.g., regulation.BonfireWarpParam)
                var paramValue = paramSource.GetValue(regulation);
                if (paramValue == null) continue;

                // Get the "Entries" property
                var entriesProperty = paramValue.GetType().GetProperty("Entries");
                if (entriesProperty == null) continue;

                // Get the type of the row inside the Entries list
                var entryType = entriesProperty.PropertyType.GetGenericArguments()[0];

                // Find all properties in the row that contain "textid" (case-insensitive)
                var matches = entryType.GetProperties()
                    .Where(p => p.Name.Contains("textid", StringComparison.OrdinalIgnoreCase))
                    .Select(p => p.Name)
                    .ToList();

                if (matches.Any())
                {
                    Console.WriteLine($"Param: {paramSource.Name}");
                    Console.WriteLine($"   Fields found: {string.Join(", ", matches)}");
                    Console.WriteLine(new string('-', 30));
                }
            }*/
        }
    }

}
