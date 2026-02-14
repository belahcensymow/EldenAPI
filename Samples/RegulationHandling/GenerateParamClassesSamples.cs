using EldenRingDataExtractor;

namespace EldenAPI.Samples
{
    public static class GenerateParamClassesSamples
    {
        public static void GenerateParamClassesSample()
        {
            //Generated files can be found the bin/.../Generated/

            string gameDir = @"C:\Games\ELDEN RING\Game\";
            RegulationHandler handler = new(gameDir);
            handler.GenerateParamClasses();
        }
    }
}