using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Get traversal with depth-first search algorithm.
        /// </summary>
        /// <param name="fromNode">Node from algorithm start.</param>
        /// <returns>List in order of traversal.</returns>
        public List<Node<TypeOfNodeData, TypeOfEdgeData>> GetDepthFirstSearch(Node<TypeOfNodeData, TypeOfEdgeData> fromNode)
        {
            DepthFirstSearh<TypeOfNodeData, TypeOfEdgeData> algorithm = new DepthFirstSearh<TypeOfNodeData, TypeOfEdgeData>(this);

            return algorithm.DepthFirstSearhAlgorithm(fromNode);
        }
    }

    internal class DepthFirstSearh<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        bool[] isVisited;
        List<Node<TypeOfNodeData, TypeOfEdgeData>> resault = new List<Node<TypeOfNodeData, TypeOfEdgeData>>();

        internal DepthFirstSearh(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        internal List<Node<TypeOfNodeData, TypeOfEdgeData>> DepthFirstSearhAlgorithm(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            Inicjalize();

            DepthFirstSearch(node);

            return resault;
        }

        void Inicjalize()
        {
            isVisited = new bool[graph.NodesCount];
        }

        void DepthFirstSearch(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            resault.Add(node);
            isVisited[node.Index] = true;

            VisitNeighborNode(node);
        }

        void VisitNeighborNode(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            foreach (Node<TypeOfNodeData, TypeOfEdgeData> neighborNode in node.Neighbors)
            {
                if (!isVisited[neighborNode.Index])
                    DepthFirstSearch(neighborNode);
            }
        }
    }
}
