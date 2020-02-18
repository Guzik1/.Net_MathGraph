using System;
using System.Collections.Generic;
using System.Text;
using Graph;
using Graph.SerializableConverter;

namespace Examples
{
    public class ConverterGraph
    {
        Graph<int, int> graph = new Graph<int, int>();
        SerializableGraph<int, int> sGraph = new SerializableGraph<int, int>();
        SerializableGraphConverter<int, int> sGraphConverter;

        void GraphToSerializableGraph()
        {
            sGraphConverter = new SerializableGraphConverter<int, int>(graph);

            // Inicjalize graph.
            for(int i = 0; i < 10; i++)
                graph.AddNode(i);

            graph.AddEdge(graph[1], graph[5]);
            // End inicjalize graph.

            sGraph = sGraphConverter.GetSerializableGraph();  // Get serializable graph (convert graph to serializable graph).

            graph.RemoveNode(graph[9]);  // This remove not inclued in a sGraph
        }

        void SerializableGraphToGraph()
        {
            sGraphConverter = new SerializableGraphConverter<int, int>(graph);

            graph = sGraphConverter.GetGraphFromSerializableGraph(sGraph);
        }
    }
}
