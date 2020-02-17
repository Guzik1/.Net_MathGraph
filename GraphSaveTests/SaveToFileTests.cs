using NUnit.Framework;
using Graph.SerializableConverter;
using Graph;
using GraphSave;
using System.IO;

namespace GraphSaveTests
{
    [TestFixture]
    public class SaveToFileTests
    {
        SerializableGraph<int, int> sGraph;

        bool clearAfterTesting = true;

        string directory = @"C:\tests\";
        string fileName = "test";
        string fileNameExtension = "";

        string filePath { get { return directory + fileName + fileNameExtension; } }

        int nodeCount = 5;
        int edgeCount = 4;

        ISavable<int, int> saveToFile;

        [SetUp]
        public void Setup()
        {
            Graph<int, int> graph = new Graph<int, int>();

            SerializableGraphConverter<int, int> serializableGraph = new SerializableGraphConverter<int, int>(graph);

            for (int i = 0; i < nodeCount; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[2], graph[4]);
            graph.AddEdge(graph[4], graph[0]);

            sGraph = serializableGraph.GetSerializableGraph();
        }

        [TearDown]
        public void Clean()
        {
            if(clearAfterTesting)
                Directory.Delete(directory, true);
        }

        [Test]
        public void JsonSaveToFileTest()
        {
            Assert.AreEqual(nodeCount, sGraph.Node.Count);
            Assert.AreEqual(edgeCount, sGraph.Edge.Count);

            fileNameExtension = ".json";

            saveToFile = new JsonSaveToFile<int, int>(filePath);
            saveToFile.Save(sGraph);

            sGraph.Node.Clear();
            sGraph.Edge.Clear();

            sGraph = saveToFile.Load();

            Assert.AreEqual(nodeCount, sGraph.Node.Count);
            Assert.AreEqual(edgeCount, sGraph.Edge.Count);
        }

        [Test]
        public void BinSaveToFileTest()
        {
            Assert.AreEqual(nodeCount, sGraph.Node.Count);
            Assert.AreEqual(edgeCount, sGraph.Edge.Count);

            fileNameExtension = ".bin";

            saveToFile = new BinarySaveToFile<int, int>(filePath);
            saveToFile.Save(sGraph);

            sGraph.Node.Clear();
            sGraph.Edge.Clear();

            sGraph = saveToFile.Load();

            Assert.AreEqual(nodeCount, sGraph.Node.Count);
            Assert.AreEqual(edgeCount, sGraph.Edge.Count);
        }

        [Test]
        public void XmlSaveToFileTest()
        {
            Assert.AreEqual(nodeCount, sGraph.Node.Count);
            Assert.AreEqual(edgeCount, sGraph.Edge.Count);

            fileNameExtension = ".xml";

            saveToFile = new XmlSaveToFile<int, int>(filePath);
            saveToFile.Save(sGraph);

            sGraph.Node.Clear();
            sGraph.Edge.Clear();

            sGraph = saveToFile.Load();

            Assert.AreEqual(nodeCount, sGraph.Node.Count);
            Assert.AreEqual(edgeCount, sGraph.Edge.Count);
        }
    }
}