using Graph;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTests
{
    public class GraphCrossingTests
    {
        [Test]
        public void AddWeightedEdgeToUnweightedGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>();
            InicjalizeGraph(graph, 2);

            graph.AddEdge(graph[0], graph[1], 4);

            Assert.IsNotNull(graph[0, 1]);

            Assert.AreEqual(0, graph[0, 1].Weight);
        }

        [Test]
        public void AddDirectedEdgeToUndirectedGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>();
            InicjalizeGraph(graph, 2);

            graph.AddEdge(graph[0], graph[1]);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNotNull(graph[1, 0]);
        }

        void InicjalizeGraph(Graph<int, int> graph, int nodeCount)
        {
            for (int i = 0; i < nodeCount; i++)
                graph.AddNode(i);
        }
    }
}
