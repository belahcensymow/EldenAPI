using SoulsFormats;

namespace EldenAPI.Samples
{
    public static class MSGBNDHandlingSamples
    {
        public static void MSGBNDHandlingSample()
        {
            //For Japanese character support
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string gameDir = @"C:\Games\ELDEN RING\Game\";
            //The handler automatically finds all MSGBND files and extracts/reads them
            //You can select the MSGBND to open with and enum BNDType
            //The options are ITEM/MENU and the DLC01 and DLC02 variants
            MSGBNDHandler msgbnd = new(gameDir);

            //List of files inside a given MSGBND by ID and by Name
            foreach (var file in msgbnd.GetFiles(BNDType.ITEM))
            {
                Console.WriteLine(file);
            }

            //You can access a file either by ID or by Name
            FMG fmg = msgbnd.GetFMG(BNDType.ITEM, "WeaponInfo");

            //You can access the fmg Type Name and ID with GetInfo()
            var metadata = msgbnd.GetInfo(fmg);
            Console.WriteLine(metadata);

            foreach (var entry in fmg.Entries)
            {
                Console.WriteLine(entry);
            }

        }
    }
}