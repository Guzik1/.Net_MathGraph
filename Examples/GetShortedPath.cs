using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class GetShortedPath
    {
        // Inicjalize wieghted graph.
        Graph<int, int> graph = new Graph<int, int>(true);

        void Example()
        {
            AddNodes(6);

            graph.AddEdge(graph[0], graph[1], 3);
            graph.AddEdge(graph[0], graph[2], 10);  // weight set to 10.

            graph.AddEdge(graph[0], graph[3], 2, 53123); // weight = 2, data in edge = 1024.

            graph.AddEdge(graph[4], graph[2], 4);
            graph.AddEdge(graph[4], graph[5], 6);
            graph.AddEdge(graph[2], graph[5], 9);
            graph.AddEdge(graph[0], graph[4], 24);

            List<Edge<int, int>> shortestPath = graph.GetShortestPathDijkstraAlgorithm(graph[0], graph[5]); // Get shortest path, between node 0 and node 5.
        }

        void AddNodes(int count)
        {
            for (int i = 0; i < count; i++)
                graph.AddNode(i);
        }
    }
}
