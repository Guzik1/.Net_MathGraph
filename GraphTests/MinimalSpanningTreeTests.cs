using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Graph;

namespace GraphTests
{
    [TestFixture]
    public class MinimalSpanningTreeTests
    {
        Graph<int, int> graph;

        [SetUp]
        public void SetUp()
        {
            graph = new Graph<int, int>(true);

            for (int i = 0; i < 5; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1], 5);
            graph.AddEdge(graph[0], graph[2], 3);
            graph.AddEdge(graph[0], graph[4], 1);

            graph.AddEdge(graph[1], graph[2], 4);
            graph.AddEdge(graph[1], graph[3], 8);

            graph.AddEdge(graph[2], graph[3], 9);
            graph.AddEdge(graph[4], graph[3], 2);
            graph.AddEdge(graph[4], graph[2], 5);
        }

        [Test]
        public void MSTKruskal()
        {
            List<Edge<int, int>> mst = graph.GetMinimalSpanningTreeKruskal();

            TestAllEdge(graph[0, 4], mst);
            TestAllEdge(graph[3, 4], mst);
            TestAllEdge(graph[0, 2], mst);
            TestAllEdge(graph[1, 2], mst);
        }

        [Test]
        public void MSTPrim()
        {
            List<Edge<int, int>> mst = graph.GetMinimalSpanningTreePrim();

            TestAllEdge(graph[0, 4], mst);
            TestAllEdge(graph[3, 4], mst);
            TestAllEdge(graph[0, 2], mst);
            TestAllEdge(graph[1, 2], mst);
        }

        void TestAllEdge(Edge<int, int> expect, List<Edge<int, int>> minimalSpanningTree)
        {
            bool check = false;

            for(int i = 0; i < minimalSpanningTree.Count; i++)
            {
                if (TestEdge(expect, minimalSpanningTree[i]))
                    check = true;
            }

            Assert.IsTrue(check);
        }

        bool TestEdge(Edge<int, int> expect, Edge<int, int> actual)
        {
            if (expect.NodeFrom == actual.NodeFrom && expect.NodeTo == actual.NodeTo)
                return true;
            else if (expect.NodeFrom == actual.NodeTo && expect.NodeTo == actual.NodeFrom)
                return true;
            else
                return false;
        }
    }
}
