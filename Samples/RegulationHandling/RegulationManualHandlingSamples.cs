using EldenRingDataExtractor;
using SoulsFormats;

namespace EldenAPI.Samples
{
    public static class RegulationManualHandlingSamples
    {
        public static void RegulationManualHandlingSample()
        {
            string gameDir = @"C:\Games\ELDEN RING\Game\";
            RegulationHandler regulation = new(gameDir);

            //Gets the list of files inside regulation.bin after decompression
            List<BinderFile> regulationFilesList = regulation.GetFiles();

            //List of files inside regulation.bin by ID and by Name
            foreach (var file in regulationFilesList)
            {
                Console.WriteLine(file);
            }

            //You can access a file either by ID or by Name
            //The correct paramdef is applied by default
            PARAM param = regulation.GetFile("BonefireWarpParam");

            //You can access the param Name or ID with GetInfo()
            Console.WriteLine($"ID: {regulation.GetInfo(param).ID}, Name: {regulation.GetInfo(param).Name}");



            foreach (var file in regulationFilesList)
            {
                //Finds te correct name for the .xml definition
                //Different from the param Name and from the param type
                //You can pass a param file, the Name, the ID or a BinderFile
                Console.WriteLine(regulation.GetParamdefName(file));
            }

            //The GetParamdefName function has a patching dictionnary
            //because of inconsistencies of naming and typos from ER developers
        }
    }
}