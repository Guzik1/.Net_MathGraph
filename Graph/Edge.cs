namespace Graph
{
    /// <summary>
    /// Object repersent a edge from graph, beetwen two node (node from to node to).
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    public class Edge<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// The start node.
        /// </summary>
        public Node<TypeOfNodeData, TypeOfEdgeData> NodeFrom { get; set; }

        /// <summary>
        /// The end node.
        /// </summary>
        public Node<TypeOfNodeData, TypeOfEdgeData> NodeTo { get; set; }

        /// <summary>
        /// Edge data.
        /// </summary>
        public TypeOfEdgeData Data { get; set; }

        /// <summary>
        /// Edge weight
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Convert this object to string.
        /// Converting format:
        /// </summary>
        /// <code>return $"Edge: { NodeFrom.Data } -> { NodeTo.Data }, weight { Weight }, data: { Data.ToString() }"</code>
        /// <returns>String of Edge object.</returns>
        public override string ToString()
        {
            return $"Edge: { NodeFrom.Data } -> { NodeTo.Data }, weight { Weight }, data: { Data.ToString() }";
        }
    }
}
