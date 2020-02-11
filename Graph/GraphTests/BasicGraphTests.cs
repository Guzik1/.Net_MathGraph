using NUnit.Framework;
using Graph;
using System.Collections.Generic;

namespace GraphTests
{
    public class BasicGraphTests
    {
        [Test]
        public void AddNodeTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            for (int i = 0; i < 10; i++)
                graph.AddNode(i);
             
            Assert.AreEqual(10, graph.NodesCount);
        }

        [Test]
        public void RemoveNodeTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            for (int i = 0; i < 10; i++)
                graph.AddNode(i);

            graph.RemoveNode(graph[1]);
            graph.RemoveNode(graph[2]);

            Assert.AreEqual(8, graph.NodesCount);
            Assert.AreNotEqual(1, graph[1]);
            Assert.AreNotEqual(2, graph[2]);
        }

        [Test]
        public void AddEdgeTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            for (int i = 0; i < 10; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[1], graph[3]);
            graph.AddEdge(graph[3], graph[2]);
            graph.AddEdge(graph[2], graph[4]);
            graph.AddEdge(graph[3], graph[4]);
            graph.AddEdge(graph[4], graph[5]);
            graph.AddEdge(graph[3], graph[7]);
            graph.AddEdge(graph[3], graph[6]);
            graph.AddEdge(graph[8], graph[6]);
            graph.AddEdge(graph[8], graph[9]);
            graph.AddEdge(graph[7], graph[9]);
            graph.AddEdge(graph[5], graph[9]);
            graph.AddEdge(graph[5], graph[7]);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNotNull(graph[0, 2]);
            Assert.IsNotNull(graph[1, 3]);
            Assert.IsNotNull(graph[3, 2]);
            Assert.IsNotNull(graph[2, 4]);
            Assert.IsNotNull(graph[3, 4]);
            Assert.IsNotNull(graph[4, 5]);
            Assert.IsNotNull(graph[3, 7]);
            Assert.IsNotNull(graph[3, 6]);
            Assert.IsNotNull(graph[8, 6]);
            Assert.IsNotNull(graph[8, 9]);
            Assert.IsNotNull(graph[7, 9]);
            Assert.IsNotNull(graph[5, 9]);
            Assert.IsNotNull(graph[5, 7]);

            Assert.IsNull(graph[5, 0]);
            Assert.IsNull(graph[8, 1]);
        }

        [Test]
        public void RemoveEdgeTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            for (int i = 0; i < 4; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[1], graph[3]);
            graph.AddEdge(graph[3], graph[2]);

            Assert.IsNotNull(graph[0, 1]);
            Assert.IsNotNull(graph[0, 2]);
            Assert.IsNotNull(graph[1, 3]);
            Assert.IsNotNull(graph[3, 2]);

            graph.RemoveEdge(graph[0], graph[1]);
            graph.RemoveEdge(graph[0], graph[2]);
            graph.RemoveEdge(graph[1], graph[3]);
            graph.RemoveEdge(graph[3], graph[2]);

            Assert.IsNull(graph[0, 1]);
            Assert.IsNull(graph[0, 2]);
            Assert.IsNull(graph[1, 3]);
            Assert.IsNull(graph[3, 2]);
        }


        [Test]
        public void GetAllEdgeTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            for (int i = 0; i < 4; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[1], graph[3]);
            graph.AddEdge(graph[3], graph[2]);

            List<Edge<int, int>> edges = graph.GetAllEdges();

            Assert.AreEqual(8, edges.Count);

            Assert.AreEqual(0, edges.Find(n => n.From.Index == 0).From.Index);
            Assert.AreEqual(1, edges.Find(n => n.From.Index == 1).From.Index);
        }
    }
}