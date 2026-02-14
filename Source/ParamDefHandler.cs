using SoulsFormats;

namespace EldenAPI
{
    //definitionFileName ex: BonfireWarpParam.xml
    public class ParamDefHandler
    {
        private string _defPath;
        private string _definitionFileName { set; get; }
        private PARAMDEF _paramdef;
        public ParamDefHandler(string definitionFileName)
        {
            _definitionFileName = definitionFileName;
            _defPath = Path.Join(@"Definitions/", definitionFileName);
            _paramdef = PARAMDEF.XmlDeserialize(_defPath, validateFields: false);
        }

        public void GetFileName()
        {
            Console.WriteLine(_definitionFileName);
        }

        public PARAMDEF GetPARAMDEF()
        {
            return _paramdef;
        }
    }
}