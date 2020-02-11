using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Graph;

namespace GraphTests
{
    public class BijkstraPathTests
    {
        [Test]
        public void ShortedPathDijkstraAlgorithmTests()
        {
            Graph<int, int> graph = new Graph<int, int>(true);

            for (int i = 0; i < 10; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1], 4);
            graph.AddEdge(graph[0], graph[2], 2);
            graph.AddEdge(graph[1], graph[3], 2);
            graph.AddEdge(graph[3], graph[2], 5);
            graph.AddEdge(graph[2], graph[4], 1);
            graph.AddEdge(graph[3], graph[4], 6);
            graph.AddEdge(graph[4], graph[5], 4);
            graph.AddEdge(graph[3], graph[7], 9);
            graph.AddEdge(graph[3], graph[6], 7);
            graph.AddEdge(graph[8], graph[6], 3);
            graph.AddEdge(graph[8], graph[9], 7);
            graph.AddEdge(graph[7], graph[9], 3);
            graph.AddEdge(graph[5], graph[9], 5);
            graph.AddEdge(graph[5], graph[7], 4);

            List<Edge<int, int>> shortestPath = graph.GetShortestPathDijkstraAlgorithm(graph[7], graph[0]);

            Assert.AreEqual(4, shortestPath.Count);

            Assert.AreEqual(7, shortestPath[0].From.Index);
            Assert.AreEqual(5, shortestPath[0].To.Index);
            Assert.AreEqual(4, shortestPath[1].To.Index);
            Assert.AreEqual(2, shortestPath[2].To.Index);
            Assert.AreEqual(0, shortestPath[3].To.Index);
            Assert.AreEqual(2, shortestPath[3].From.Index);

            int weightSum = 0;
            for (int i = 0; i < shortestPath.Count; i++)
                weightSum += shortestPath[i].Weight;

            Assert.AreEqual(11, weightSum);
        }
    }
}
