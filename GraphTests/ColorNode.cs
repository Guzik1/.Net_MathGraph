using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Graph;

namespace GraphTests
{
    [TestFixture]
    public class ColorNode
    {
        [Test]
        public void GetColorsArrayForNodeInGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>(true);

            for (int i = 0; i < 6; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            graph.AddEdge(graph[1], graph[3]);
            graph.AddEdge(graph[2], graph[3]);
            graph.AddEdge(graph[2], graph[5]);
            graph.AddEdge(graph[3], graph[4]);
            graph.AddEdge(graph[3], graph[5]);
            graph.AddEdge(graph[4], graph[5]);

            int[] colors = graph.GetColors();

            Assert.AreEqual(0, colors[0]);
            Assert.AreEqual(1, colors[1]);
            Assert.AreEqual(1, colors[2]);
            Assert.AreEqual(0, colors[3]);
            Assert.AreEqual(1, colors[4]);
            Assert.AreEqual(2, colors[5]);
        }
    }
}
