using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class DirectedAndWeightedGraph
    {
        Graph<int, int> graph = new Graph<int, int>(true, true);

        void Example()
        {
            AddNodes(5);

            graph.AddEdge(graph[0], graph[1], 10);
            graph.AddEdge(graph[0], graph[2], 3);
            graph.AddEdge(graph[2], graph[0], 2);
            graph.AddEdge(graph[4], graph[1], 6);

            Edge<int, int> edge01 = graph[0, 1];  // return edge between node 0 and 1.
            Edge<int, int> edge10 = graph[1, 0]; // return null, because node 1 canot connect to node 0.

            Console.WriteLine(edge01.Weight);
        }

        void AddNodes(int count)
        {
            for (int i = 0; i < count; i++)
                graph.AddNode(i);
        }
    }
}
