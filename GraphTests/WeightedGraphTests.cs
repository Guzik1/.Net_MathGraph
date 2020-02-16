using Graph;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTests
{
    public class WeightedGraphTests
    {
        Graph<int, int> graph;

        int nodeCountToInicjalize = 4;

        [SetUp]
        public void InicjalizeConverterTests()
        {
            graph = new Graph<int, int>();

            for (int i = 0; i < nodeCountToInicjalize; i++)
                graph.AddNode(i);
        }

        [Test]
        public void CreateWeightedGraphTest()
        {
            Assert.IsFalse(graph.IsDirected);
            Assert.IsTrue(graph.IsWeighted);
        }

        [Test]
        public void AddEdgeTest()
        {
            graph.AddEdge(graph[0], graph[1], 4);
            graph.AddEdge(graph[0], graph[2], 2);
            graph.AddEdge(graph[1], graph[3], 1);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNotNull(graph[0, 2]);
            Assert.IsNotNull(graph[1, 3]);

            Assert.AreEqual(4, graph[0, 1].Weight);
            Assert.AreEqual(2, graph[0, 2].Weight);
            Assert.AreEqual(1, graph[1, 3].Weight);
        }

        [Test]
        public void RemoveEdgeTest()
        {
            graph.AddEdge(graph[0], graph[1], 4);
            graph.AddEdge(graph[0], graph[2], 2);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNotNull(graph[0, 2]);

            Assert.AreEqual(4, graph[0, 1].Weight);
            Assert.AreEqual(2, graph[0, 2].Weight);

            graph.RemoveEdge(graph[0], graph[1]);
            graph.RemoveEdge(graph[0], graph[2]);

            Assert.IsNull(graph[0, 1]);
            Assert.IsNull(graph[0, 2]);
        }
    }
}
