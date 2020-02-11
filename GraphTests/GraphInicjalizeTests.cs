using System;
using System.Collections.Generic;
using System.Text;
using Graph;
using NUnit.Framework;

namespace GraphTests
{
    public class GraphInicjalizeTests
    {
        [Test]
        public void BasicGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>();

            Assert.IsFalse(graph.IsDirected);
            Assert.IsFalse(graph.IsWeighted);

            graph = new Graph<int, int>(false, false);

            Assert.IsFalse(graph.IsDirected);
            Assert.IsFalse(graph.IsWeighted);
        }

        [Test]
        public void WeightedGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>(true);

            Assert.IsFalse(graph.IsDirected);
            Assert.IsTrue(graph.IsWeighted);
        }

        [Test]
        public void DirectedGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>(isDirected: true);

            Assert.IsTrue(graph.IsDirected);
            Assert.IsFalse(graph.IsWeighted);

            graph = new Graph<int, int>(false, true);

            Assert.IsTrue(graph.IsDirected);
            Assert.IsFalse(graph.IsWeighted);
        }

        [Test]
        public void WeightedAndDirectedGraphTest()
        {
            Graph<int, int> graph = new Graph<int, int>(true, true);

            Assert.IsTrue(graph.IsDirected);
            Assert.IsTrue(graph.IsWeighted);
        }
    }
}
