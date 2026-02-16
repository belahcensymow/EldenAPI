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
            //foreach (var file in msgbndHandler.GetFiles(BNDType.ITEMDLC2)) Console.WriteLine(file);



            var regions = regulation.BonfireWarpTabParam.Entries;
            var subregions = regulation.BonfireWarpSubCategoryParam.Entries;
            var sitesOfGrace = regulation.BonfireWarpParam.Entries;
            var landmarks = regulation.WorldMapPointParam.Entries;

            FMG npcName = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "NpcName");
            FMG npcNameDLC1 = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "NpcName_dlc01");
            FMG npcNameDLC2 = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "NpcName_dlc02");
            
            FMG placeName = msgbndHandler.GetFMG(BNDType.ITEMDLC2, 19);
            FMG placeNameDLC1 = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "PlaceName_dlc01");
            FMG placeNameDLC2 = msgbndHandler.GetFMG(BNDType.ITEMDLC2, "PlaceName_dlc02");
            
            FMG menuText = msgbndHandler.GetFMG(BNDType.MENUDLC2, "MenuText");
            FMG menuTextDLC1 = msgbndHandler.GetFMG(BNDType.MENUDLC2, "MenuText_dlc01");
            FMG menuTextDLC2 = msgbndHandler.GetFMG(BNDType.MENUDLC2, "MenuText_dlc02");

            string GetSubcategory(int bonfireSubCategoryId)
            {
                foreach (var subregion in subregions)
                {
                    if (subregion.ID == bonfireSubCategoryId) return msgbndHandler.TextIdToText([menuText, menuTextDLC1], subregion.textId);
                }
                return bonfireSubCategoryId.ToString();
            }

            string GetCategory(int bonfireSubCategoryId)
            {
                foreach (var subregion in subregions)
                {
                    if (subregion.ID == bonfireSubCategoryId)
                    {
                        foreach (var region in regions)
                        {
                            if (region.ID == subregion.tabId) return msgbndHandler.TextIdToText([menuText, menuTextDLC1], region.textId);
                        }
                    }
                }
                return bonfireSubCategoryId.ToString();
            }
            
            foreach (var region in regions)
            {
                //Console.WriteLine($"{region} {msgbndHandler.TextIdToText([menuText, menuTextDLC1], region.textId)}");
            }

            foreach (var subregion in subregions)
            {
                //Console.WriteLine($"{subregion} {msgbndHandler.TextIdToText([menuText, menuTextDLC1], subregion.textId)}");
            }
            /*
            foreach (var siteOfGrace in sitesOfGrace)
            {
                if (siteOfGrace.bonfireSubCategoryId != 0)
                    Console.WriteLine($"" +
                        $"{GetCategory(siteOfGrace.bonfireSubCategoryId)} : " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId1)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId2)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId3)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId4)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId5)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId6)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId7)} | " +
                        $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId8)} | " +
                        $"{{{siteOfGrace.posX},{siteOfGrace.posY},{siteOfGrace.posZ}}}");
            }
            */

            foreach (var landmark in landmarks)
            {
                //Console.WriteLine($"" +
                //$"{GetCategory(landmark.)} : " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId1)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId2)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId3)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId4)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId5)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId6)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId7)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId8)} | " +
                //$"{{{landmark.posX},{landmark.posY},{landmark.posZ}}}");
                Console.WriteLine(landmark);
                //Console.WriteLine(GetSubcategory(12059165));
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


            //Type type = sitesOfGrace.ToList()[0].GetType();
            //foreach (var property in type.GetProperties())
            //{
            //    Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
            //}
            /*
            posX posY posZ : Coordinates
            textId1->8 : Name
            iconId : Icon sprite
            clearedEventFlagId : alternate icon color ?
            isAreaIcon : Icon scale, makes icon bigger
            areaNo: 61 60 11 etc what are Limgrave and such
            gridXNo gridZNo : Xhorizontal Zvertical tile
            dispMinZoomStep : At what zoom level you start seeing it 0 for everything
             */
        }
    }

}
