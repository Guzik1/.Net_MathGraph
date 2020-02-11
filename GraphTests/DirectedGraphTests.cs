using Graph;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTests
{
    public class DirectedGraphTests
    {
        Graph<int, int> graph;

        [Test]
        public void CreateDirectedGraphTest()
        {
            Assert.IsTrue(graph.IsDirected);
            Assert.IsFalse(graph.IsWeighted);
        }

        [Test]
        public void AddEdgeTest()
        {
            InicjalizeGraph(3);

            graph.AddEdge(graph[0], graph[1], 4);
            graph.AddEdge(graph[0], graph[2], 2);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNull(graph[1, 0]);
            Assert.IsNotNull(graph[0, 2]);
            Assert.IsNull(graph[2, 0]);
        }

        [Test]
        public void RemoveEdgeTest()
        {
            InicjalizeGraph(3);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNull(graph[1, 0]);
            Assert.IsNotNull(graph[0, 2]);
            Assert.IsNull(graph[2, 0]);

            graph.RemoveEdge(graph[0], graph[1]);

            Assert.IsNull(graph[0, 1]);
        }

        void InicjalizeGraph(int nodeCount)
        {
            graph = new Graph<int, int>(false, true);

            for (int i = 0; i < nodeCount; i++)
                graph.AddNode(i);
        }
    }
}
