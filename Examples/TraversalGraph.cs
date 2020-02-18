using System;
using System.Collections.Generic;
using System.Text;
using Graph;

namespace Examples
{
    public class TraversalGraph
    {
        Graph<int, int> graph = new Graph<int, int>();

        void Example()
        {
            AddNodes(10);

            graph.AddEdge(graph[0], graph[1]);
            graph.AddEdge(graph[0], graph[2]);
            // ** etc add more edges ** //

            List<Node<int, int>> DFS = graph.GetDepthFirstSearch(graph[0]);  // depth traverse.
            List<Node<int, int>> BFS = graph.GetBreadthFirstSearch(graph[0]);  // breadth traverse.
        }

        void AddNodes(int count)
        {
            for (int i = 0; i < count; i++)
                graph.AddNode(i);
        }
    }
}
