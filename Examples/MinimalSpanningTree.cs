using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class MinimalSpanningTree
    {
        Graph<int, int> graph;

        void Example()
        {
            SetUp();

            List<Edge<int, int>> mst = graph.GetMinimalSpanningTreeKruskal(); // Get minimal spanning tree, kruskal algorithm (form low and medium edge dense).
            mst = graph.GetMinimalSpanningTreePrim();  // Get minimal spanning tree, prim algorithm (form high edge dense).

            mst.ForEach((n) => Console.WriteLine(n.NodeFrom + " - " + n.NodeTo + ", weight: " + n.Weight));
        }

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
    }
}
