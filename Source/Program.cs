using System.Numerics;
using System.Reflection;
using EldenRingDataExtractor;
using SoulsFormats;

namespace EldenAPI
{
    class Program
    {

        public static void FindAllNameProperties(RegulationHandler regulation)
        {
            var paramClasses = regulation.GetType().GetProperties()
                .Where(p => p.PropertyType.Namespace == "EldenRingDataExtractor"
                         && !p.Name.Equals("RegulationMetadata"));

            foreach (var paramProp in paramClasses)
            {
                var paramInstance = paramProp.GetValue(regulation);
                if (paramInstance == null) continue;
                var entriesProp = paramInstance.GetType().GetProperty("Entries");
                if (entriesProp == null) continue;
                var entries = entriesProp.GetValue(paramInstance) as System.Collections.IEnumerable;
                var firstEntry = entries?.Cast<object>().FirstOrDefault();
                if (firstEntry == null) continue;
                Type entryType = firstEntry.GetType();
                var nameProps = entryType.GetProperties().Where(p => p.Name.Contains("category", StringComparison.OrdinalIgnoreCase)).ToList();
                if (nameProps.Any())
                {
                    Console.WriteLine($"--- Class: {paramProp.Name} ---");
                    foreach (var prop in nameProps)
                    {
                        Console.WriteLine($"    Property: {prop.PropertyType.Name} {prop.Name}");
                    }
                    Console.WriteLine();
                }
            }
        }
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
                    if (subregion.ID == bonfireSubCategoryId) return $"{msgbndHandler.TextIdToText([menuText, menuTextDLC1], subregion.textId)}";
                }
                return bonfireSubCategoryId.ToString();
            }

            string GetCategoryOfSubCategory(int bonfireSubCategoryId)
            {
                foreach (var subregion in subregions)
                {
                    if (subregion.ID == bonfireSubCategoryId)
                    {
                        foreach (var region in regions)
                        {
                            if (region.ID == subregion.tabId) return msgbndHandler.TextIdToText([menuText, menuTextDLC1, placeName, placeNameDLC1], region.textId);
                        }
                    }
                }
                return bonfireSubCategoryId.ToString();
            }

            string GetCategory(int bonfireSubCategoryId)
            {
                return msgbndHandler.TextIdToText([menuText, menuTextDLC1, placeName, placeNameDLC1], bonfireSubCategoryId);
            }

            //foreach (var region in regions)
            //{
            //    Console.WriteLine($"{region} {GetCategory(region.textId)}");
            //}

            Dictionary<int, (Vector3 min, Vector3 max)> ranges = [];
            foreach (var site in sitesOfGrace)
            {
                var id = site.bonfireSubCategoryId;
                if (!ranges.ContainsKey(id)) ranges.Add(id, (
                    new(float.MaxValue, float.MaxValue, float.MaxValue),
                    new(float.MinValue, float.MinValue, float.MinValue)));
                var current = ranges[id];
                Vector3 updatedMin = new(Math.Min(current.min.X, site.posX),
                                         Math.Min(current.min.Y, site.posY),
                                         Math.Min(current.min.Z, site.posZ));
                Vector3 updatedMax = new(Math.Max(current.max.X, site.posX),
                                         Math.Max(current.max.Y, site.posY),
                                         Math.Max(current.max.Z, site.posZ));
                ranges[id] = (updatedMin, updatedMax);
            }



            (string value, int stage) GetLandmarkSubregion(WorldMapPointParamRow landmark)
            {
                List<FMG> fmgList = [placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2];
                foreach (var siteOfGrace in sitesOfGrace)
                {
                    if (msgbndHandler.TextIdToText(fmgList, landmark.textId1) == msgbndHandler.TextIdToText(fmgList, siteOfGrace.textId1))
                    {
                        return (GetCategory(siteOfGrace.textId1), 1);
                    }
                }
                foreach (var siteOfGrace in sitesOfGrace)
                {
                    if (landmark.areaNo == siteOfGrace.areaNo && landmark.gridXNo == siteOfGrace.gridXNo && landmark.gridZNo == siteOfGrace.gridZNo)
                    {
                        return (GetSubcategory(siteOfGrace.bonfireSubCategoryId), 2);
                    }
                }
                foreach (var range in ranges)
                {
                    if (landmark.posX > range.Value.min.X && landmark.posX < range.Value.max.X &&
                        landmark.posY > range.Value.min.Y && landmark.posY < range.Value.max.Y &&
                        landmark.posZ > range.Value.min.Z && landmark.posZ < range.Value.max.Z)
                    {
                        return (GetSubcategory(range.Key), 3);
                    }
                }
                return ($"{landmark.areaNo}_{landmark.gridXNo}_{landmark.gridZNo}", 4);
            }


            HashSet<BonfireWarpParamRow> bonefireNames = [];
            foreach (var siteOfGrace in sitesOfGrace)
            {
                string name = msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId1);
                if(!int.TryParse(name, out _)) bonefireNames.Add(siteOfGrace);
                if (siteOfGrace.bonfireSubCategoryId != 0) if (siteOfGrace.iconId != 1) continue;
                //        Console.WriteLine($"{siteOfGrace.iconId}" +
                //            $"{GetCategory(siteOfGrace.bonfireSubCategoryId)} : " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId1)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId2)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId3)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId4)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId5)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId6)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId7)} | " +
                //            $"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], siteOfGrace.textId8)} | " +
                //            $"{{{siteOfGrace.posX},{siteOfGrace.posY},{siteOfGrace.posZ}}}");
                //Console.WriteLine($"{{{siteOfGrace.gridXNo},{siteOfGrace.gridZNo}}} : {GetSubcategory(siteOfGrace.bonfireSubCategoryId)}");
            }

            foreach (var bonefire in bonefireNames.ToList().OrderBy(bonefire => bonefire.bonfireSubCategoryId))
            {
                string bonefireName = msgbndHandler
                    .TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], bonefire.textId1);
                foreach (var landmark in landmarks)
                {
                    string landmarkName = msgbndHandler
                        .TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId1);
                    if (landmarkName == bonefireName)
                    {
                        //Console.WriteLine($"subcategoryID : {bonefire.bonfireSubCategoryId} | {GetSubcategory(bonefire.bonfireSubCategoryId)}");
                        //Console.WriteLine($"landmark      : {landmark.areaNo}_{landmark.gridXNo}_{landmark.gridZNo}");
                        //Console.WriteLine($"bonefire      : {bonefire.areaNo}_{bonefire.gridXNo}_{bonefire.gridZNo}");

                        //Console.WriteLine($"landmark | ID : {landmark.ID} | {landmark.areaNo}_{landmark.gridXNo}_{landmark.gridZNo} | textId1 : {landmark.textId1} | {landmarkName}");
                        //Console.WriteLine($"bonefire | ID : {bonefire.ID} | {bonefire.areaNo}_{bonefire.gridXNo}_{bonefire.gridZNo} | textId1 : {bonefire.textId1} | {bonefireName}");
                        //Console.WriteLine();
                        break;
                    }
                }
            }
            Dictionary<int, HashSet<string>> grids = [];
            //foreach (var siteOfGrace in sitesOfGrace.ToList().OrderBy(sitesOfGrace => sitesOfGrace.bonfireSubCategoryId))
            //{
            //    if (!grids.ContainsKey(siteOfGrace.bonfireSubCategoryId)) grids.Add(siteOfGrace.bonfireSubCategoryId, []);
            //    else grids[siteOfGrace.bonfireSubCategoryId].Add($"{siteOfGrace.areaNo}_{siteOfGrace.gridXNo}_{siteOfGrace.gridZNo}");
            //}
            //foreach (var grid in grids)
            //{
            //    Console.Write($"{grid.Key} : ");
            //    foreach (var value in grid.Value)
            //    {
            //        Console.Write($"| {value} ");
            //    }
            //    Console.WriteLine();
            //}

            foreach (var landmark in landmarks)
            {
                if (landmark.textId1 == -1 && landmark.textId2 == -1 && landmark.textId3 == -1 && landmark.textId4 == -1 && landmark.textId5 == -1 && landmark.textId6 == -1 && landmark.textId7 == -1 && landmark.textId8 == -1) continue;
                if (landmark.textId1 == -1) continue;
                var result = GetLandmarkSubregion(landmark);
                string name = (msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId1));
                if (result.stage == 3)
                {
                    Console.WriteLine($"Subregion : {result.value} \nLandmark  : {name}");
                    Console.WriteLine();
                }
                //Console.WriteLine($"" +
                //$"{GetCategory(landmark.ID)} : " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId1)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId2)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId3)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId4)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId5)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId6)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId7)} | " +
                //$"{msgbndHandler.TextIdToText([placeName, placeNameDLC1, placeNameDLC2, npcName, npcNameDLC1, npcNameDLC2], landmark.textId8)} | " +
                //$" ");
                //$"{{{landmark.posX},{landmark.posY},{landmark.posZ}}}");
            }


            //FindAllNameProperties(regulation);
            

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


            //Type type = regulation.BonfireWarpParam.Entries.ToList()[0].GetType();
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
