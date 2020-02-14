using System;
using System.Collections.Generic;
using System.Text;
using Graph;
using Graph.SerializableConverter;
using NUnit.Framework;

namespace GraphTests
{
    [TestFixture]
    public class GraphToSerializableGraphConverterTests
    {
        //TODO Add tests!

        [Test]
        public void GraphSerializeTest()
        {

        }

        [Test]
        public void GraphConverterTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            for (int i = 0; i < 5; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[0], graph[3]);

            graph.AddEdge(graph[2], graph[3]);
            graph.AddEdge(graph[1], graph[3]);

            Assert.IsNotNull(graph[2, 3]);
            Assert.IsNotNull(graph[1, 3]);

            SerializableGraphConverter<int, int> sConverter = new SerializableGraphConverter<int, int>(graph);

            SerializableGraph<int, int> sGraph = sConverter.GetSerializableGraph();

            GraphSave.XmlSaveToFile<int, int> file = new GraphSave.XmlSaveToFile<int, int>(@"A:\test.xml");
            file.Save(sGraph);

            graph.RemoveEdge(graph[2], graph[3]);
            graph.RemoveEdge(graph[1], graph[3]);
            graph.RemoveNode(graph[3]);

            graph = sConverter.SetGraphFromSerializableGraph(sGraph);

            Assert.AreEqual(5, graph.NodesCount);

            // Nodes serialize OK!
            Assert.AreEqual(10, graph.GetAllEdges().Count);
            Assert.IsNotNull(graph[2, 3]);
            Assert.IsNotNull(graph[1, 3]);
        }
    }
}
