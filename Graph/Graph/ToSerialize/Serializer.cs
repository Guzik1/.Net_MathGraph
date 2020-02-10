using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.ToSerialize
{
    public class Serializer<TypeOfNodeData, TypeOfEdgeData>
    {
        public SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData> Serialize(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
        {
            SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData> serialized = new SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData>
            {
                IsDirected = graph.IsDirected,
                IsWeighted = graph.IsWeighted,
                Node = new List<SerializedNode<TypeOfNodeData>>(),
            };
            
            // Node
            for (int i = 0; i < graph.NodesCount; i++)
                serialized.Node.Add(SerializeNode(graph[i]));

            //Edge
            if (graph.IsDirected)
                serialized.Edge = SerializeDirectedEdge(graph);
            else
                serialized.Edge = SerializeUndirectedEdge(graph);

            return serialized;
        }

        public Graph<TypeOfNodeData, TypeOfEdgeData> Deserialize(SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData> serializedGraph)
        {
            Graph<TypeOfNodeData, TypeOfEdgeData> deserialized = new Graph<TypeOfNodeData, TypeOfEdgeData>(serializedGraph.IsWeighted, serializedGraph.IsDirected);

            // Node
            for(int i = 0; i < serializedGraph.Node.Count; i++)
                deserialized.AddNode(serializedGraph.Node[i].Data);

            // Edge
            SerializedEdge<TypeOfEdgeData> edge;
            for (int i = 0; i < serializedGraph.Edge.Count; i++)
            {
                edge = serializedGraph.Edge[i];

                deserialized.AddEdge(deserialized[edge.NodeFromId], deserialized[edge.NodeToId], edge.Weight, edge.Data);
            }

            return deserialized;
        }

        List<SerializedEdge<TypeOfEdgeData>> SerializeDirectedEdge(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
        {
            List<SerializedEdge<TypeOfEdgeData>> edges = new List<SerializedEdge<TypeOfEdgeData>>();

            Node<TypeOfNodeData, TypeOfEdgeData> node = new Node<TypeOfNodeData, TypeOfEdgeData>();
            for (int i = 0; i < graph.NodesCount; i++)
            {
                node = graph[i];

                for (int j = 0; j < node.Neighbors.Count; j++)
                    edges.Add(SerializeEdge(node, j));
            }

            return edges;
        }

        List<SerializedEdge<TypeOfEdgeData>> SerializeUndirectedEdge(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
        {
            List<SerializedEdge<TypeOfEdgeData>> edges = new List<SerializedEdge<TypeOfEdgeData>>();

            Node<TypeOfNodeData, TypeOfEdgeData> node = new Node<TypeOfNodeData, TypeOfEdgeData>();
            SerializedEdge<TypeOfEdgeData> edge = new SerializedEdge<TypeOfEdgeData>();
            for (int i = 0; i < graph.NodesCount; i++)
            {
                node = graph[i];

                for (int j = 0; j < node.Neighbors.Count; j++)
                {
                    edge = SerializeEdge(node, j);

                    int index = edges.FindIndex(n => n.NodeToId == edge.NodeFromId);

                    if(index == -1)
                        edges.Add(edge);
                }
            }

            return edges;
        }

        SerializedNode<TypeOfNodeData> SerializeNode(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            return new SerializedNode<TypeOfNodeData>
            {
                Data = node.Data
            };
        }

        SerializedEdge<TypeOfEdgeData> SerializeEdge(Node<TypeOfNodeData, TypeOfEdgeData> node, int index)
        {
            return new SerializedEdge<TypeOfEdgeData>
            {
                NodeFromId = node.Index,
                NodeToId = node.Neighbors[index].Index,
                Weight = node.Weights[index],
                Data = node.EdgeData[index]
            };
        }
    }
}
