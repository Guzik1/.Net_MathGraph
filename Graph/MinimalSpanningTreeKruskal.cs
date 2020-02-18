using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Get minimal spanning tree from graph. MST is a minimal weight connect to all node in graph.
        /// Use for low and medium edge dense in graph, compared to node count. Edge is E, node V: O(E log V);
        /// </summary>
        /// <returns>List of edge including minimal spanning tree.</returns>
        public List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetMinimalSpanningTreeKruskal()
        {
            MinimalSpanningTreeKruskal<TypeOfNodeData, TypeOfEdgeData> mstk = new MinimalSpanningTreeKruskal<TypeOfNodeData, TypeOfEdgeData>(this);

            return mstk.KruskalAlgorithm();
        }
    }

    internal class MinimalSpanningTreeKruskal<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        List<Edge<TypeOfNodeData, TypeOfEdgeData>> edges;
        Queue<Edge<TypeOfNodeData, TypeOfEdgeData>> queue;
        NodeSubset<TypeOfNodeData, TypeOfEdgeData>[] subsets;

        List<Edge<TypeOfNodeData, TypeOfEdgeData>> result = new List<Edge<TypeOfNodeData, TypeOfEdgeData>>();

        Edge<TypeOfNodeData, TypeOfEdgeData> edge;
        Node<TypeOfNodeData, TypeOfEdgeData> from, to;

        internal MinimalSpanningTreeKruskal(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        internal List<Edge<TypeOfNodeData, TypeOfEdgeData>> KruskalAlgorithm()
        {
            AlgorithmInicjalize();

            while (result.Count < graph.NodesCount - 1)
            {
                edge = queue.Dequeue();
                from = GetRoot(edge.NodeFrom);
                to = GetRoot(edge.NodeTo);

                AddEdgeWhenNodesAreNotEqual();
            }

            return result;
        }

        void AlgorithmInicjalize()
        {
            edges = graph.GetAllEdges();
            edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

            queue = new Queue<Edge<TypeOfNodeData, TypeOfEdgeData>>(edges);

            subsets = new NodeSubset<TypeOfNodeData, TypeOfEdgeData>[graph.NodesCount];
            InicjalizeSubsetsArray();
        }

        void InicjalizeSubsetsArray()
        {
            for (int i = 0; i < graph.NodesCount; i++)
                subsets[i] = new NodeSubset<TypeOfNodeData, TypeOfEdgeData>() { Parent = graph[i] };
        }

        void AddEdgeWhenNodesAreNotEqual()
        {
            if (from != to)
            {
                result.Add(edge);
                Union(from, to);
            }
        }

        Node<TypeOfNodeData, TypeOfEdgeData> GetRoot(Node<TypeOfNodeData, TypeOfEdgeData> node)
        {
            if(subsets[node.Index].Parent != node)
                subsets[node.Index].Parent = GetRoot(subsets[node.Index].Parent);

            return subsets[node.Index].Parent;
        }

        void Union(Node<TypeOfNodeData, TypeOfEdgeData> a, Node<TypeOfNodeData, TypeOfEdgeData> b)
        {
            if (subsets[a.Index].Rank > subsets[b.Index].Rank)
                subsets[b.Index].Parent = a;
            else if (subsets[a.Index].Rank < subsets[b.Index].Rank)
                subsets[a.Index].Parent = b;
            else
            {
                subsets[b.Index].Parent = a;
                subsets[a.Index].Rank++;
            }
        }
    }

    internal class NodeSubset<TypeOfNodeData, TypeOfEdgeData>
    {
        internal Node<TypeOfNodeData, TypeOfEdgeData> Parent { get; set; }
        internal int Rank { get; set; }
    }
}
