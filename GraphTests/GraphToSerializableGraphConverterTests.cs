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
        Graph<int, int> graph;

        int nodeCountToInicjalize = 5;

        [SetUp]
        public void InicjalizeConverterTests()
        {
            graph = new Graph<int, int>();

            for (int i = 0; i < nodeCountToInicjalize; i++)
                graph.AddNode(i);
        }

        [Test]
        public void GraphSerializebleConverterNodesTest()
        {
            SerializableGraphConverter<int, int> converter = new SerializableGraphConverter<int, int>(graph);
            SerializableGraph<int, int> sGraph = converter.GetSerializableGraph();

            Assert.AreEqual(5, sGraph.Node.Count);
        }

        [Test]
        public void GraphSerializebleConverterEdgeTest()
        {
            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[0], graph[3]);

            SerializableGraphConverter<int, int> converter = new SerializableGraphConverter<int, int>(graph);
            SerializableGraph<int, int> sGraph = converter.GetSerializableGraph();

            Assert.AreNotEqual(6, sGraph.Edge.Count);
            Assert.AreEqual(3, sGraph.Edge.Count);
        }

        [Test]
        public void GraphSerializebleConverterDirectedEdgeAndNodeTest()
        {
            graph = new Graph<int, int>(false, true);

            for (int i = 0; i < 5; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[0], graph[3]);
            graph.AddEdge(graph[1], graph[2]);
            graph.AddEdge(graph[3], graph[1]);

            SerializableGraphConverter<int, int> converter = new SerializableGraphConverter<int, int>(graph);
            SerializableGraph<int, int> sGraph = converter.GetSerializableGraph();

            Assert.AreEqual(5, sGraph.Edge.Count);
        }

        [Test]
        public void GraphConverterSerializeAndDeserializeTest()
        {
            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[0], graph[3]);

            graph.AddEdge(graph[2], graph[3]);
            graph.AddEdge(graph[1], graph[3]);

            Assert.IsNotNull(graph[2, 3]);
            Assert.IsNotNull(graph[1, 3]);

            SerializableGraphConverter<int, int> sConverter = new SerializableGraphConverter<int, int>(graph);
            SerializableGraph<int, int> sGraph = sConverter.GetSerializableGraph();

            graph.RemoveEdge(graph[2], graph[3]);
            graph.RemoveEdge(graph[1], graph[3]);
            graph.RemoveNode(graph[3]);

            Assert.AreEqual(4, graph.NodesCount);

            graph = sConverter.SetGraphFromSerializableGraph(sGraph);

            Assert.AreEqual(5, graph.NodesCount);

            Assert.AreEqual(10, graph.GetAllEdges().Count);
            Assert.IsNotNull(graph[2, 3]);
            Assert.IsNotNull(graph[1, 3]);
        }
    }
}
