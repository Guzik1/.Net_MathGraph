using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class GetColors
    {
        void Example()
        {
            Graph<int, int> graph = new Graph<int, int>(true);

            //** Inicjalize graph
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
            // ** End inicjalziation

            int[] colors = graph.GetColors(); // Get colors number for graph nodes.

            Console.WriteLine($"Color node { graph[0].Index } color is { colors[0] }");
        }
    }
}
