using static EldenAPI.XmlParser;

namespace EldenAPI.Samples
{
    //This was my attempt to implement a nodeTree style paramdef analyzed
    //Before I found the Paramdex library of course
    //No need to use this
    //Still has cool stuff so might document it later
    public static class XmlParserSamples
    {
        public static void XmlParserSample()
        {
            //string gameDir = @"C:\Games\ELDEN RING\Game\";
            //string definitionsPath = @"Definitions/";
            //string output = @"Output2";
            //static string regPath = Path.Combine(gameDir, "regulation.bin");
            //static string msgDir = Path.Combine(gameDir, @"msg\engus");
            //static string defDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Paramdex", "ER", "Defs");

            XmlParser xmlParser = new();
            List<NodeTree> nodeTrees = xmlParser.GenerateTree();
            HashSet<string> dataTypes = [];
            foreach (var nodeTree in nodeTrees)
            {
                dataTypes.UnionWith(GetDataTypes(nodeTree));
            }
            //GetDataTypes(nodeTrees[12]);
            foreach (var dataType in dataTypes)
            {
                Console.WriteLine(dataType);
            }
            Names names = new();
            GetAllNames(nodeTrees, names);
            DisplayNames(names);
            DisplayAllTypes(nodeTrees);
        }
    }
}