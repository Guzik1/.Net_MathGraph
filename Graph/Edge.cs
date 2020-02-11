namespace Graph
{
    /// <summary>
    /// Object repersent a edge from graph.
    /// </summary>
    /// <typeparam name="T">Type of node data.</typeparam>
    /// <typeparam name="R">Type of edge data.</typeparam>
    public class Edge<T, R>
    {
        /// <summary>
        /// The start node.
        /// </summary>
        public Node<T, R> From { get; set; }

        /// <summary>
        /// The end node.
        /// </summary>
        public Node<T, R> To { get; set; }

        /// <summary>
        /// Edge data.
        /// </summary>
        public R Data { get; set; }

        /// <summary>
        /// Edge weight
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Convert this object to string.
        /// </summary>
        /// <returns>String of object</returns>
        public override string ToString()
        {
            return $"Edge: { From.Data } -> { To.Data }, weight { Weight }, data: { Data.ToString() }";
        }
    }
}
