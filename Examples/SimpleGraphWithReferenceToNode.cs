using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class SimpleGraphWithReferenceToNode
    {
        // Create undirected and unweighted graph.
        Graph<int, int> graph = new Graph<int, int>();

        int nodeCount = 3;

        Node<int, int> node4;

        void Example()
        {
            for (int i = 0; i < nodeCount; i++)
                graph.AddNode();  // Add node to graph and list of node reference

            node4 = graph.AddNode(4);

            graph.AddEdge(graph[0], graph[4], edgeData: 10);  // Add edge when edge data is 10 (byte type).
            graph.AddEdge(graph[5], graph[2]);  // Add edge without data in edge.
            // ... add etc graph edge ... //

            graph.RemoveEdge(graph[0], node4);  // Remove edge from graph, between node id 0 and node id 4.

            graph.RemoveNode(graph[1]);  // Remove node id 1, node 2 and more nodes, update index (n-1).

            Node<int, int> node0 = graph[0]; // return node from index.
            Edge<int, int> edge01 = graph[0, 1];  // parameters [node from, node to], return edge beetwen node from and node to.

            Console.WriteLine(node4.Data);  // Acces to data.
            Console.WriteLine(graph[0].EdgeData[0]);
        }
    }
}
