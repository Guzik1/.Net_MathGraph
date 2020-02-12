using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// This class represent a mathematical graph with data in nodes and edges.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of data in nodes.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of data in edges.</typeparam>
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Return true when graph is directed or otherwise false
        /// </summary>
        public bool IsDirected { get; } = false;

        /// <summary>
        /// Return true when graph is weighted or otherwise false
        /// </summary>
        public bool IsWeighted { get; } = false;

        List<Node<TypeOfNodeData, TypeOfEdgeData>> Nodes { get; set; } = new List<Node<TypeOfNodeData, TypeOfEdgeData>>();

        #region Constructors
        /// <summary>
        /// Inicjalize weighted and directed graph, select graph directed and weighted type.
        /// </summary>
        /// <param name="isDirected">Set true to direct a graph, for undirected set false.</param>
        /// <param name="isWeighted">Set true to weighted a edge, for unwegihted set false.</param>
        public Graph(bool isWeighted = false, bool isDirected = false)
        {
            this.IsDirected = isDirected;
            this.IsWeighted = isWeighted;
        }

        /// <summary>
        /// Inicjalize weighted graph, select graph weighted type. (Set isDirected to false)
        /// </summary>
        /// <param name="isWeighted">Set true to weighted a edge, for unwegihted set false.</param>
        public Graph(bool isWeighted = false)
        {
            this.IsDirected = false;
            this.IsWeighted = isWeighted;
        }

        /// <summary>
        /// Inicjalize standard graph, unweighted and undirected.
        /// </summary>
        public Graph()
        {
            this.IsDirected = false;
            this.IsWeighted = false;
        }
        #endregion

        /// <summary>
        /// Get the edge between two nodes (from, to).
        /// </summary>
        /// <param name="from">Edge FROM the node.</param>
        /// <param name="to">Edge TO the node.</param>
        /// <returns>Edge between node FROM and node TO.</returns>
        public Edge<TypeOfNodeData, TypeOfEdgeData> this[int from, int to]
        {
            get
            {
                Node<TypeOfNodeData, TypeOfEdgeData> nodeFrom = Nodes[from];
                Node<TypeOfNodeData, TypeOfEdgeData> nodeTo = Nodes[to];

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
                From = nodeFrom,
                To = nodeTo,
                Data = nodeFrom.EdgeData[neighborId],
                Weight = neighborId < nodeFrom.Weights.Count ? nodeFrom.Weights[neighborId] : 0
            };
        }

        /// <summary>
        /// Get the node from node number.
        /// </summary>
        /// <param name="nodeNumber">Number of node.</param>
        /// <returns>Node</returns>
        public Node<TypeOfNodeData, TypeOfEdgeData> this[int nodeNumber]
        {
            get
            {
                return Nodes[nodeNumber];
            }
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
        /// Add edge between two node (from, to) and/or weight and/or data in edge.
        /// </summary>
        /// <param name="from">Node from edge start.</param>
        /// <param name="to">Node to edge end.</param>
        /// <param name="weight">Weight of edge, default 0 (use for weighted graph)</param>
        /// <param name="edgeData">The edge data, default 'default of data'.</param>
        public void AddEdge(Node<TypeOfNodeData, TypeOfEdgeData> from, Node<TypeOfNodeData, TypeOfEdgeData> to, int weight = 0, TypeOfEdgeData edgeData = default)
        {
            from.Neighbors.Add(to);

            if (IsWeighted)
                from.Weights.Add(weight);
            if (edgeData != null)
                from.EdgeData.Add(edgeData);

            if (!IsDirected)
            {
                to.Neighbors.Add(from);

                if (IsWeighted)
                    to.Weights.Add(weight);

                if (edgeData != null)
                    to.EdgeData.Add(edgeData);
            }
        }

        /// <summary>
        /// Remove a edge between node FROM and node TO.
        /// </summary>
        /// <param name="from">Node of start edge.</param>
        /// <param name="to">Node of end edge.</param>
        public void RemoveEdge(Node<TypeOfNodeData, TypeOfEdgeData> from, Node<TypeOfNodeData, TypeOfEdgeData> to)
        {
            int index = from.Neighbors.FindIndex(n => n == to);

            if(index >= 0)
            {
                from.Neighbors.RemoveAt(index);

                if (IsWeighted)
                    from.Weights.RemoveAt(index);
            }
        }

        /// <summary>
        /// Get all of edge in graph.
        /// </summary>
        /// <returns>List of all edges in graph.</returns>
        public List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetAllEdges()
        {
            List<Edge<TypeOfNodeData, TypeOfEdgeData>> edges = new List<Edge<TypeOfNodeData, TypeOfEdgeData>>();

            foreach(Node<TypeOfNodeData, TypeOfEdgeData> from in Nodes)
            {
                for(int i = 0; i < from.Neighbors.Count; i++)
                {
                    Edge<TypeOfNodeData, TypeOfEdgeData> edge = BuildEdge(from, from.Neighbors[i], i);

                    edges.Add(edge);
                }
            }

            return edges;
        }

        void UpdateIndices()
        {
            int i = 0;
            Nodes.ForEach(n => n.Index = i++);
        }
    }
}
