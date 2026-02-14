using EldenRingDataExtractor;

namespace EldenAPI.Samples
{
    public static class RegulationSamples
    {
        public static void RegulationSample()
        {
            //For Japanese character support
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string gameDir = @"C:\Games\ELDEN RING\Game\";
            RegulationHandler regulation = new(gameDir);

            foreach (var entry in regulation.BonfireWarpParam.Entries)
            {
                //Print the entries
                Console.WriteLine(entry);
            }

            foreach (var entry in regulation.BonfireWarpParam.Entries)
            {
                //Or select the entries that you want
                Console.WriteLine($"X: {entry.posX} Y: {entry.posY} Z: {entry.posZ}");
            }

            foreach (var entry in regulation.BonfireWarpParam.Entries)
            {
                // The Name and ID are accessible too(might be empty)
                Console.WriteLine($"ID: {entry.ID} | Name: {entry.Name}");
            }
        }
    }

}