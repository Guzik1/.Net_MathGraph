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

        SerializableGraph<TypeOfNodeData, TypeOfEdgeData> serializedGraph;

        /// <summary>
        /// Use this constructor to set a graph reference to convert on serializable graph.
        /// </summary>
        /// <param name="graph">Graph reference.</param>
        public SerializableGraphConverter( Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        /// <summary>
        /// Convert graph to serializable graph.
        /// </summary>
        /// <returns>Serializable graph data model.</returns>
        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> GetSerializableGraph()
        {
            serializedGraph = new SerializableGraph<TypeOfNodeData, TypeOfEdgeData>
            {
                IsDirected = graph.IsDirected,
                IsWeighted = graph.IsWeighted,

                Node = RewriteNodeToSerializableNode(),
                Edge = RewriteEdgeToSerializableEdge()
            };

            return serializedGraph;
        }

        /// <summary>
        /// Convert serializable graph to graph.
        /// </summary>
        /// <returns>Graph data model.</returns>
        public Graph<TypeOfNodeData, TypeOfEdgeData> GetGraphFromSerializableGraph(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> serializedGraph)
        {
            graph = new Graph<TypeOfNodeData, TypeOfEdgeData>(serializedGraph.IsWeighted, serializedGraph.IsDirected);

            RewriteSerializableNodeToNodes();

            RewriteSerializableEdgeToEdges();

            return graph;
        }

        List<SerializableNode<TypeOfNodeData>> RewriteNodeToSerializableNode()
        {
            List<SerializableNode<TypeOfNodeData>> serializable = new List<SerializableNode<TypeOfNodeData>>();

            for (int i = 0; i < graph.NodesCount; i++)
                serializable.Add(SerializeNodeElement(graph[i]));

            return serializable;
        }

        void RewriteSerializableNodeToNodes()
        {
            for (int i = 0; i < serializedGraph.Node.Count; i++)
                graph.AddNode(serializedGraph.Node[i].Data);
        }

        void RewriteSerializableEdgeToEdges()
        {
            SerializableEdge<TypeOfEdgeData> edge;
            for (int i = 0; i < serializedGraph.Edge.Count; i++)
            {
                edge = serializedGraph.Edge[i];

                graph.AddEdge(graph[edge.NodeFromId], graph[edge.NodeToId], edge.Weight, edge.Data);
            }
        }

        List<SerializableEdge<TypeOfEdgeData>> RewriteEdgeToSerializableEdge()
        {
            if (graph.IsDirected)
                return SerializeDirectedEdge();
            else
                return SerializeUndirectedEdge();
        }

        List<SerializableEdge<TypeOfEdgeData>> SerializeDirectedEdge()
        {
            List<SerializableEdge<TypeOfEdgeData>> edges = new List<SerializableEdge<TypeOfEdgeData>>();

            Node<TypeOfNodeData, TypeOfEdgeData> node;
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

            Node<TypeOfNodeData, TypeOfEdgeData> node;
            SerializableEdge<TypeOfEdgeData> edge;
            for (int i = 0; i < graph.NodesCount; i++)
            {
                node = graph[i];

                for (int j = 0; j < node.Neighbors.Count; j++)
                {
                    edge = SerializeEdge(node, j);

                    int index = edges.FindIndex(n => n.NodeToId == edge.NodeFromId && n.NodeFromId == edge.NodeToId);   // <---------------------

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
                Weight = node.Weights.Count > 0 ? node.Weights[index] : 0,
                Data = node.EdgeData[index]
            };
        }
    }
}
