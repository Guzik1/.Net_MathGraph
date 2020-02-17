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
        /// <returns>List in order of traversal.</returns>
        public List<Node<TypeOfNodeData, TypeOfEdgeData>> GetDepthFirstSearch()
        {
            DepthFirstSearh<TypeOfNodeData, TypeOfEdgeData> algorithm = new DepthFirstSearh<TypeOfNodeData, TypeOfEdgeData>(this);

            return algorithm.DepthFirstSearhAlgorithm();
        }
    }

    internal class DepthFirstSearh<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        internal DepthFirstSearh(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        bool[] isVisited;
        List<Node<TypeOfNodeData, TypeOfEdgeData>> resault = new List<Node<TypeOfNodeData, TypeOfEdgeData>>();

        internal List<Node<TypeOfNodeData, TypeOfEdgeData>> DepthFirstSearhAlgorithm()
        {
            Inicjalize();

            DepthFirstSearch(graph[0]);

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

            foreach(Node<TypeOfNodeData, TypeOfEdgeData> neighborNode in node.Neighbors)
            {
                if (!isVisited[neighborNode.Index])
                    DepthFirstSearch(neighborNode);
            }
        }
    }
}
