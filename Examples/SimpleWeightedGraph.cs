using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class SimpleWeightedGraph
    {
        // Inicjalize wieghted graph.
        Graph<int, int> graph = new Graph<int, int>(true);

        void Example()
        {
            AddNodes(5);

            graph.AddEdge(graph[0], graph[1]);  // Add edge, edge weight is set to 0.
            graph.AddEdge(graph[0], graph[2], 10);  // weight set to 10.

            graph.AddEdge(graph[0], graph[3], 2, 1024); // weight = 2, data in edge = 1024.

            graph.RemoveEdge(graph[0], graph[1]);

            Console.WriteLine(graph[0].ToString());
        }

        void AddNodes(int count)
        {
            for (int i = 0; i < count; i++)
                graph.AddNode(i);
        }
    }
}
