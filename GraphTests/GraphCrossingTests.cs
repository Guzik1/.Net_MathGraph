using Graph;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTests
{
    public class GraphCrossingTests
    {
        Graph<int, int> graph;

        int nodeCountToInicjalize = 2;

        [SetUp]
        public void InicjalizeConverterTests()
        {
            graph = new Graph<int, int>();

            for (int i = 0; i < nodeCountToInicjalize; i++)
                graph.AddNode(i);
        }

        [Test]
        public void AddWeightedEdgeToUnweightedGraphTest()
        {
            graph.AddEdge(graph[0], graph[1], 4);

            Assert.IsNotNull(graph[0, 1]);

            Assert.AreEqual(0, graph[0, 1].Weight);
        }

        [Test]
        public void AddDirectedEdgeToUndirectedGraphTest()
        {
            graph.AddEdge(graph[0], graph[1]);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNotNull(graph[1, 0]);
        }
    }
}
