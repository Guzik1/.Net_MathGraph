using System;
using System.Collections.Generic;
using System.Text;
using Graph;
using NUnit.Framework;

namespace GraphTests
{
    [TestFixture]
    public class BreadthFirstSearchAlgorithmTests
    {
        [Test]
        public void SimpleBreadthFirstSearchTest()
        {
            Graph<int, int> graph = new Graph<int, int>(false, true);

            for (int i = 0; i < 6; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[1], graph[2]);
            graph.AddEdge(graph[1], graph[3]);
            graph.AddEdge(graph[3], graph[1]);
            graph.AddEdge(graph[2], graph[3]);
            graph.AddEdge(graph[3], graph[4]);

            List<Node<int, int>> nodesBFS = graph.GetDepthFirstSearch(graph[0]);

            Assert.IsNotNull(nodesBFS);

            Assert.AreEqual(0, nodesBFS[0].Index);
            Assert.AreEqual(1, nodesBFS[1].Index);
            Assert.AreEqual(2, nodesBFS[2].Index);
            Assert.AreEqual(3, nodesBFS[3].Index);
            Assert.AreEqual(4, nodesBFS[4].Index);

            Assert.AreEqual(5, nodesBFS.Count);
        }
    }
}
