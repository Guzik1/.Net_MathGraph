using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Graph;

namespace GraphTests
{
    [TestFixture]
    class DepthFirstSearchGraphAlgorithmTests
    {
        [Test]
        public void DepthFirstSearchTest()
        {
            Graph<int, int> graph = new Graph<int, int>(false, true);

            for (int i = 0; i < 6; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[1], graph[2]);
            graph.AddEdge(graph[1], graph[4]);
            graph.AddEdge(graph[1], graph[3]);
            graph.AddEdge(graph[0], graph[3]);

            graph.AddEdge(graph[1], graph[0]);

            List<Node<int, int>> nodesDFS = graph.GetDepthFirstSearch(graph[0]);

            Assert.IsNotNull(nodesDFS);

            Assert.AreEqual(0, nodesDFS[0].Index);
            Assert.AreEqual(1, nodesDFS[1].Index);
            Assert.AreEqual(2, nodesDFS[2].Index);
            Assert.AreEqual(4, nodesDFS[3].Index);
            Assert.AreEqual(3, nodesDFS[4].Index);

            Assert.AreEqual(5, nodesDFS.Count);
        }
    }
}
