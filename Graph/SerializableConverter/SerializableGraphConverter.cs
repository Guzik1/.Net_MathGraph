using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    /// <summary>
    /// Class to convert unserializable graph to serializable graph and vice versa.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    public class SerializableGraphConverter<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> serializedGraph;


        public SerializableGraphConverter(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        public SerializableGraphConverter(SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> serializedGraph)
            => this.serializedGraph = serializedGraph;

        public SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> GetSerializableGraph()
        {
            serializedGraph = new SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData>
            {
                IsDirected = graph.IsDirected,
                IsWeighted = graph.IsWeighted,

                Node = RewriteNodeToSerializableNode(),
                Edge = RewriteToSerializableEdge()
            };

            return serializedGraph;
        }

        public Graph<TypeOfNodeData, TypeOfEdgeData> SetGraphFromSerializableGraph()
        {
            graph = new Graph<TypeOfNodeData, TypeOfEdgeData>(serializedGraph.IsWeighted, serializedGraph.IsDirected);

            RewriteSerializableNodeToNode();

            // Edge
            SerializableEdge<TypeOfEdgeData> edge;
            for (int i = 0; i < serializedGraph.Edge.Count; i++)
            {
                edge = serializedGraph.Edge[i];

                graph.AddEdge(graph[edge.NodeFromId], graph[edge.NodeToId], edge.Weight, edge.Data);
            }

            return graph;
        }

        List<SerializableNode<TypeOfNodeData>> RewriteNodeToSerializableNode()
        {
            List<SerializableNode<TypeOfNodeData>> serializable = new List<SerializableNode<TypeOfNodeData>>();

            for (int i = 0; i < graph.NodesCount; i++)
                serializable.Add(SerializeNodeElement(graph[i]));

            return serializable;
        }

        void RewriteSerializableNodeToNode()
        {
            for (int i = 0; i < serializedGraph.Node.Count; i++)
                graph.AddNode(serializedGraph.Node[i].Data);
        }

        List<SerializableEdge<TypeOfEdgeData>> RewriteToSerializableEdge()
        {
            if (graph.IsDirected)
                return SerializeDirectedEdge();
            else
                return SerializeUndirectedEdge();
        }

        List<SerializableEdge<TypeOfEdgeData>> SerializeDirectedEdge()
        {
            List<SerializableEdge<TypeOfEdgeData>> edges = new List<SerializableEdge<TypeOfEdgeData>>();

            Node<TypeOfNodeData, TypeOfEdgeData> node = new Node<TypeOfNodeData, TypeOfEdgeData>();
            for (int i = 0; i < graph.NodesCount; i++)
            {
                node = graph[i];

                for (int j = 0; j < node.Neighbors.Count; j++)
                    edges.Add(SerializeEdge(node, j));
            }

            return edges;
        }

        List<SerializableEdge<TypeOfEdgeData>> SerializeUndirectedEdge()
        {
            List<SerializableEdge<TypeOfEdgeData>> edges = new List<SerializableEdge<TypeOfEdgeData>>();

            Node<TypeOfNodeData, TypeOfEdgeData> node = new Node<TypeOfNodeData, TypeOfEdgeData>();
            SerializableEdge<TypeOfEdgeData> edge = new SerializableEdge<TypeOfEdgeData>();
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

        SerializableNode<TypeOfNodeData> SerializeNodeElement(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            return new SerializableNode<TypeOfNodeData>
            {
                Data = node.Data
            };
        }

        SerializableEdge<TypeOfEdgeData> SerializeEdge(Node<TypeOfNodeData, TypeOfEdgeData> node, int index)
        {
            return new SerializableEdge<TypeOfEdgeData>
            {
                NodeFromId = node.Index,
                NodeToId = node.Neighbors[index].Index,
                Weight = node.Weights[index],
                Data = node.EdgeData[index]
            };
        }
    }
}
