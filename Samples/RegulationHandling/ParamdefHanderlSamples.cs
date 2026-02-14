using EldenRingDataExtractor;
using SoulsFormats;

namespace EldenAPI.Samples
{
    public static class ParamdefHandlerSamples
    {
        public static void ParamdefHandlerSample()
        {
            //If you don't want to rely on the automatic PARAMDEF application at the PARAM creation
            //You can manually use the ApplyParamdef() function

            string gameDir = @"C:\Games\ELDEN RING\Game\";
            RegulationHandler regulation = new(gameDir);
            PARAM param = regulation.GetFile("AssetEnvironmentGeometryParam");

            //Either provide the name of the .xml
            //Or use the GetParamdefName function to automatically identify and return the correct one
            //string paramdefName = regulation.GetParamdefName(param);
            string paramdefName = "AssetGeometryParam.xml";

            ParamDefHandler paramdefHandler = new(paramdefName);
            PARAMDEF paramdef = paramdefHandler.GetPARAMDEF();

            param.ApplyParamdef(paramdef);

        }
    }
}