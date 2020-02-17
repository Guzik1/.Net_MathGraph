using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Get traversal with breadth-first search algorithm.
        /// </summary>
        /// <param name="fromNode">Node from algorithm start.</param>
        /// <returns>List in order of traversal.</returns>
        public List<Node<TypeOfNodeData, TypeOfEdgeData>> GetBreadthFirstSearch(Node<TypeOfNodeData, TypeOfEdgeData> fromNode)
        {
            BreadthFirstSearch<TypeOfNodeData, TypeOfEdgeData> algorithm = new BreadthFirstSearch<TypeOfNodeData, TypeOfEdgeData>(this);

            return algorithm.BreadthFirstSearchAlrogithm(fromNode);
        }
    }

    internal class BreadthFirstSearch<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        bool[] isVisited;

        List<Node<TypeOfNodeData, TypeOfEdgeData>> resault = new List<Node<TypeOfNodeData, TypeOfEdgeData>>();
        Queue<Node<TypeOfNodeData, TypeOfEdgeData>> queue = new Queue<Node<TypeOfNodeData, TypeOfEdgeData>>();

        internal BreadthFirstSearch(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        internal List<Node<TypeOfNodeData, TypeOfEdgeData>> BreadthFirstSearchAlrogithm(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            Inicjalize();
            isVisited[node.Index] = true;
            queue.Enqueue(node);

            VisitAllNode();

            return resault;
        }

        void VisitAllNode()
        {
            Node<TypeOfNodeData, TypeOfEdgeData> nextNode;
            while (queue.Count > 0)
            {
                nextNode = queue.Dequeue();
                resault.Add(nextNode);

                VisitNeighbor(nextNode);
            }
        }

        void VisitNeighbor(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            foreach (Node<TypeOfNodeData, TypeOfEdgeData> neighbor in node.Neighbors)
                VisitNode(node);
        }

        void VisitNode(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            if (NodeIsVisited(node))
            {
                isVisited[node.Index] = true;
                queue.Enqueue(node);
            }
        }

        bool NodeIsVisited(Node<TypeOfNodeData, TypeOfEdgeData> node)
            => !isVisited[node.Index];

        void Inicjalize()
        {
            isVisited = new bool[graph.NodesCount];
        }
    }
}
