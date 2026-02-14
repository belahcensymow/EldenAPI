using System.Xml;

namespace EldenAPI
{
    /// <summary>
    /// Internal utility for tree-based XML parsing of PARAMDEFS.
    /// This is a specialized parser I made before finding out about Paramdex.
    /// Use at your own caution!
    /// </summary>
    public class NodeTree
    {
        public string? Name { get; set; } = "";
        public string? Value { get; set; } = "";
        public Dictionary<string, string> Attributes { get; set; } = new();
        public List<NodeTree> Children { get; set; } = new();
        public bool IsBranch => Children.Count > 0;
        public bool IsLeaf => Children.Count == 0;
    }
    public class XmlParser
    {
        
        public class Names
        {
            public HashSet<string> elementsNames = [];
            public HashSet<string> attributesNames = [];
        }

        private List<XmlDocument> _xmlDocuments = new();
        private NodeTree _nodeTree = new();
        private Names _names = new();
        private string _definitionsPath;

        /// <summary>
        /// Default path for .xml definitions is ./Definitions
        /// </summary>
        /// <param name="definitionsPath"></param>
        public XmlParser(string definitionsPath = @"Definitions")
        {
            _definitionsPath = definitionsPath;
        }

        /// <summary>
        /// Reads files like duh
        /// </summary>
        /// <remarks>
        /// Reads the files with .xml extention and then fills the _xmlDocuments list
        /// </remarks>
        /// <param name="definitionsPath"></param>
        private void ReadFiles(string definitionsPath = @"Definitions")
        {
            if (!Directory.Exists(definitionsPath))
            {
                Console.WriteLine($"Error: Directory {definitionsPath} was not found!");
                return;
            }
                string[] files = Directory.GetFiles(definitionsPath);
                foreach (var file in files)
                {
                    if (!string.IsNullOrEmpty(file))
                    {
                        XmlDocument xmlDocument = new();
                        xmlDocument.Load(file);
                        _xmlDocuments.Add(xmlDocument);
                    }
                }
        }

        /// <summary>
        /// Returns a NodeTree from a list of XmlDocument
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <returns></returns>
        private NodeTree ParseNode(XmlNode xmlNode)
        {
            NodeTree nodeTree = new();
            nodeTree.Name = xmlNode.LocalName;
            if (xmlNode.Attributes?.Count > 0)
                foreach (XmlAttribute attributeList in xmlNode.Attributes)
                    nodeTree.Attributes[attributeList.Name] = attributeList.Value;
            if (xmlNode.HasChildNodes)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.NodeType == XmlNodeType.Element)
                        nodeTree.Children.Add(ParseNode(childNode));
                    else if(childNode.NodeType == XmlNodeType.Text)
                        nodeTree.Value += childNode.Value?.Trim() ?? "";
                }
            }
            return nodeTree;
        }

        /// <summary>
        /// Returns the NodeTree list -> Every .xml file as a tree
        /// </summary>
        /// <remarks>
        /// Invokes all the functions to read and parse to then return the NodeTree list 
        /// List(NodeTree)-> Every .xml file as a tree
        /// The NodeTree's format is simple 
        /// Every "element" or "tag" has these components
        /// Name:string, Value:string, Attributes:List(string), Children:List(NodeTree)
        /// And IsBranch:bool and IsLeaf:bool but we don't talk about them
        /// Name is the name of the tag
        /// Value is the text inside the tag mostly for leaves otherwise it's just empty ""
        /// IsBranch and IsLeave are what their names suggest and are computed properties
        /// </remarks>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public List<NodeTree> GenerateTree()
        {
            ReadFiles();
            List<NodeTree> nodeTrees = [];
            foreach (var xmlDocument in _xmlDocuments)
                if (xmlDocument.DocumentElement is { } root)
                    nodeTrees.Add(ParseNode(root));
            return nodeTrees;
        }

        /// <summary>
        /// Fills a Names object with the names of elements and attributes found
        /// </summary>
        /// <remarks>
        /// Returns a Names object containing every element name and every attribute name in the NodeTree list
        /// </remarks>
        /// <param name="nodeTrees"></param>
        /// <param name="names"></param>
        public static void GetAllNames(List<NodeTree> nodeTrees, Names names)
        {
            foreach (var nodeTree in nodeTrees ?? [])
            {
                if(!string.IsNullOrEmpty(nodeTree.Name)) names.elementsNames.Add(nodeTree.Name);
                names.attributesNames.UnionWith(nodeTree.Attributes.Keys);
                if (nodeTree.Children is not null)
                    GetAllNames(nodeTree.Children ?? [], names);
            }
        }

        /// <summary>
        /// Prints out the content of a NodeTree in correct hierarchy to the console
        /// </summary>
        /// <param name="nodeTree"></param>
        /// <param name="depth"></param>
        /// <param name="isLast"></param>
        public static void DisplayTree(NodeTree nodeTree, int depth = 0, bool isLast = false)
        {
            //string outputDirectory = @"Classes";
            string indent = new string(' ', depth * 3);
            string branch = isLast ? "└──" : "├──";
            Console.WriteLine($"{indent}{branch}{nodeTree.Name}" +
                              $"{(string.IsNullOrEmpty(nodeTree.Value) ? "" : $": \"{nodeTree.Value}\"")}");
            foreach (var attribute in nodeTree.Attributes)
                Console.WriteLine($"{indent}│  @{attribute.Key}: {attribute.Value}");

            if (!nodeTree.IsLeaf)
            {
                depth++;
                int childIndex = 0;
                foreach (var child in nodeTree.Children)
                {
                    if (childIndex == nodeTree.Children.Count - 1)
                        DisplayTree(child, depth, true);
                    else
                        DisplayTree(child, depth);
                    childIndex++;
                }
            }
        }

        public static HashSet<string> GetDataTypes(NodeTree nodeTree, int depth = 0, bool isLast = false)
        {
            HashSet<string> dataTypes = [];
            foreach (var attribute in nodeTree.Attributes)
            {
                if (attribute.Key != "Def") continue;
                    dataTypes.Add(attribute.Value.Split(" ")[0]);
            }
            if (!nodeTree.IsLeaf)
            {
                depth++;
                int childIndex = 0;
                foreach (var child in nodeTree.Children)
                {
                    if (childIndex == nodeTree.Children.Count - 1)
                        dataTypes.UnionWith(GetDataTypes(child, depth, true));
                    else
                        dataTypes.UnionWith(GetDataTypes(child, depth));
                    childIndex++;
                }
            }
            return dataTypes;
        }

        /// <summary>
        /// Display all names used in tags and attributes
        /// </summary>
        /// <param name="names"></param>
        public static void DisplayNames(Names names)
        {
            Console.WriteLine("Elements names");
            foreach (var element in names.elementsNames)
                Console.WriteLine($"  {element}");
            Console.WriteLine("Attributes names");
            foreach (var attribute in names.attributesNames)
                Console.WriteLine($"  {attribute}");
        }

        /// <summary>
        /// Display all names used in tags and attributes
        /// </summary>
        /// <param name="nodeTrees"></param>
        public static void DisplayNames(List<NodeTree> nodeTrees)
        {
            Names names = new();
            GetAllNames(nodeTrees, names);
            DisplayNames(names);
        }

        public static void DisplayAllTypes(List<NodeTree> nodeTrees)
        {
            HashSet<string> allTypes = new();

            // Internal helper to recurse through your NodeTree
            void FindTypes(NodeTree node)
            {
                // Look for the "type" attribute specifically
                if (node.Attributes.ContainsKey("type"))
                {
                    allTypes.Add(node.Attributes["type"]);
                }

                // Some XMLs use "displayformat" for the actual data type
                if (node.Attributes.ContainsKey("displayformat"))
                {
                    allTypes.Add(node.Attributes["displayformat"]);
                }

                foreach (var child in node.Children)
                {
                    FindTypes(child);
                }
            }

            foreach (var tree in nodeTrees)
            {
                FindTypes(tree);
            }

            Console.WriteLine("=== ALL DISCOVERED XML TYPES ===");
            foreach (var t in allTypes.OrderBy(x => x))
            {
                Console.WriteLine($"Found Type: {t}");
            }
        }

    }
}