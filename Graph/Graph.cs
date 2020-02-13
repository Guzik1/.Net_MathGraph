using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// This class represent a mathematical graph with data in nodes and edges. This version can't be serialized.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of data in nodes.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of data in edges.</typeparam>
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Return true when graph is directed or otherwise return false.
        /// </summary>
        public bool IsDirected { get; } = false;

        /// <summary>
        /// Return true when graph is weighted or otherwise return false.
        /// </summary>
        public bool IsWeighted { get; } = false;

        List<Node<TypeOfNodeData, TypeOfEdgeData>> Nodes { get; set; } = new List<Node<TypeOfNodeData, TypeOfEdgeData>>();

        #region Constructors
        /// <summary>
        /// Inicajlizing the graph, select whether it is a weighted or a directed chart.
        /// </summary>
        /// <param name="isDirected">Set true for initialize directed graph, or false for inicjalize undirected graph.</param>
        /// <param name="isWeighted">Set true for initialize weighted graph, or false for inicjalize unweighted graph.</param>
        public Graph(bool isWeighted = false, bool isDirected = false)
        {
            this.IsDirected = isDirected;
            this.IsWeighted = isWeighted;
        }

        /// <summary>
        /// Inicajlizing the graph, select whether it is a weighted graph.
        /// </summary>
        /// <param name="isWeighted">Set true for initialize weighted graph, or false for inicjalize unweighted graph.</param>
        public Graph(bool isWeighted = false)
        {
            this.IsDirected = false;
            this.IsWeighted = isWeighted;
        }

        /// <summary>
        /// Inicajlizing the simple graph (unweighted and undirected graph).
        /// </summary>
        public Graph()
        {
            this.IsDirected = false;
            this.IsWeighted = false;
        }
        #endregion

        /// <summary>
        /// Get the edge between two nodes (node from and node to).
        /// </summary>
        /// <param name="nodeFromId">Node id where the edge begin.</param>
        /// <param name="nodeToId">Node id where the edge end.</param>
        /// <returns>Edge between node FROM and node TO.</returns>
        public Edge<TypeOfNodeData, TypeOfEdgeData> this[int nodeFromId, int nodeToId]
        {
            get
            {
                Node<TypeOfNodeData, TypeOfEdgeData> nodeFrom = Nodes[nodeFromId];
                Node<TypeOfNodeData, TypeOfEdgeData> nodeTo = Nodes[nodeToId];

                int neighborId = nodeFrom.Neighbors.IndexOf(nodeTo);

                if(IsNeighbor(neighborId))
                    return BuildEdge(nodeFrom, nodeTo, neighborId);

                return null;
            }
        }

        bool IsNeighbor(int weightToNode)
            => weightToNode >= 0;

        Edge<TypeOfNodeData, TypeOfEdgeData> BuildEdge(Node<TypeOfNodeData, TypeOfEdgeData> nodeFrom, Node<TypeOfNodeData, TypeOfEdgeData> nodeTo, int neighborId)
        {
            return new Edge<TypeOfNodeData, TypeOfEdgeData>()
            {
                NodeFrom = nodeFrom,
                NodeTo = nodeTo,
                Data = nodeFrom.EdgeData[neighborId],
                Weight = neighborId < nodeFrom.Weights.Count ? nodeFrom.Weights[neighborId] : 0
            };
        }

        /// <summary>
        /// Get the node reference from node id.
        /// </summary>
        /// <param name="nodeNumber">Id of node.</param>
        /// <returns>Node reference</returns>
        public Node<TypeOfNodeData, TypeOfEdgeData> this[int nodeNumber]
        {
            get => Nodes[nodeNumber];
        }

        /// <summary>
        /// Get nodes count in graph.
        /// </summary>
        /// <returns>Nodes count</returns>
        public int NodesCount => Nodes.Count;

        /// <summary>
        /// Add node to graph.
        /// </summary>
        /// <param name="value">Data in node.</param>
        /// <returns>Return added node to list of all nodes.</returns>
        public Node<TypeOfNodeData, TypeOfEdgeData> AddNode(TypeOfNodeData value)
        {
            Node<TypeOfNodeData, TypeOfEdgeData> node = new Node<TypeOfNodeData, TypeOfEdgeData>() { Data = value };

            Nodes.Add(node);

            UpdateIndices();

            return node;
        }

        /// <summary>
        /// Remove node from the graph.
        /// </summary>
        /// <param name="nodeToRemove">Node to remove.</param>
        public void RemoveNode(Node<TypeOfNodeData, TypeOfEdgeData> nodeToRemove)
        {
            Nodes.Remove(nodeToRemove);

            UpdateIndices();

            RemoveAllEdgeToNode(nodeToRemove);
        }

        void RemoveAllEdgeToNode(Node<TypeOfNodeData, TypeOfEdgeData> nodeToConnection)
        {
            foreach (Node<TypeOfNodeData, TypeOfEdgeData> node in Nodes)
                RemoveEdge(node, nodeToConnection);
        }

        /// <summary>
        /// Add edge between two node (from, to) and data in edge. For weighted graph add also weight.
        /// </summary>
        /// <param name="from">Node from the edge begin.</param>
        /// <param name="to">Node to the edge end.</param>
        /// <param name="weight">Weight of edge, default 0 (use for weighted graph)</param>
        /// <param name="edgeData">The edge data, default 'default of data'.</param>
        public void AddEdge(Node<TypeOfNodeData, TypeOfEdgeData> from, Node<TypeOfNodeData, TypeOfEdgeData> to, int weight = 0, TypeOfEdgeData edgeData = default)
        {
            AddEdgeToOneNode(from, to, weight, edgeData);

            if (!IsDirected)
                AddEdgeToOneNode(to, from, weight, edgeData);
        }

        void AddEdgeToOneNode(Node<TypeOfNodeData, TypeOfEdgeData> from, Node<TypeOfNodeData, TypeOfEdgeData> to, int weight = 0, TypeOfEdgeData edgeData = default)
        {
            from.Neighbors.Add(to);

            if (IsWeighted)
                from.Weights.Add(weight);

            if (edgeData != null)
                from.EdgeData.Add(edgeData);
        }

        /// <summary>
        /// Remove a edge between node FROM and node TO.
        /// </summary>
        /// <param name="nodeFrom">Node where the edge begin.</param>
        /// <param name="nodeTo">Node where the edge end.</param>
        public void RemoveEdge(Node<TypeOfNodeData, TypeOfEdgeData> nodeFrom, Node<TypeOfNodeData, TypeOfEdgeData> nodeTo)
        {
            RemoveOneEdge(nodeFrom, nodeTo);

            if(!IsDirected)
                RemoveOneEdge(nodeTo, nodeFrom);
        }

        void RemoveOneEdge(Node<TypeOfNodeData, TypeOfEdgeData> from, Node<TypeOfNodeData, TypeOfEdgeData> to)
        {
            int neighborIndex = from.Neighbors.FindIndex(n => n == to);

            if (neighborIndex >= 0)
            {
                from.Neighbors.RemoveAt(neighborIndex);

                if (IsWeighted)
                    from.Weights.RemoveAt(neighborIndex);
            }
        }

        /// <summary>
        /// Get all of edge in graph.
        /// </summary>
        /// <returns>List of all edges in graph.</returns>
        public List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetAllEdges()
        {
            List<Edge<TypeOfNodeData, TypeOfEdgeData>> edges = new List<Edge<TypeOfNodeData, TypeOfEdgeData>>();

            foreach (Node<TypeOfNodeData, TypeOfEdgeData> nodeFrom in Nodes)
                AddAllNeighborEdges(edges, nodeFrom);

            return edges;
        }

        void AddAllNeighborEdges(List<Edge<TypeOfNodeData, TypeOfEdgeData>> edgesList, Node<TypeOfNodeData, TypeOfEdgeData> nodeFrom)
        {
            for (int i = 0; i < nodeFrom.Neighbors.Count; i++)
            {
                Edge<TypeOfNodeData, TypeOfEdgeData> edge = BuildEdge(nodeFrom, nodeFrom.Neighbors[i], i);

                edgesList.Add(edge);
            }
        }

        void UpdateIndices()
        {
            int i = 0;
            Nodes.ForEach(n => n.Index = i++);
        }
    }
}
