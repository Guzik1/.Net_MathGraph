using System;
using Graph;

namespace Examples
{
    // Simple example without using reference to nodes 
    public class SimpleGraph
    {
        // Create undirected and unweighted graph.
        Graph<long, byte> graph = new Graph<long, byte>();

        int nodeCount = 10;

        void Example()
        {
            for (int i = 0; i < nodeCount; i++)
                graph.AddNode(i);  // Add node, when i is a node data.

            graph.AddEdge(graph[0], graph[1], edgeData: 10);  // Add edge when edge data is 10 (byte type).
            graph.AddEdge(graph[5], graph[2]);  // Add edge without data in edge.
            // ... add etc graph edge ... //

            graph.RemoveEdge(graph[0], graph[1]);  // Remove edge from graph, between node id 0 and node id 1.

            graph.RemoveNode(graph[1]);  // Remove node id 1, node 2 and more nodes, update index (n-1).

            Node<long, byte> node0 = graph[0]; // return node from index.
            Edge<long, byte> edge01 = graph[0, 1];  // parameters [node from, node to], return edge beetwen node from and node to.

            Console.WriteLine(graph[0].Data);  // Acces to data.
            Console.WriteLine(graph[0].EdgeData[0]);
        }
    }
}
