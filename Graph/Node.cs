using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Represent a Node in graph.
    /// </summary>
    /// <typeparam name="T">Type of Node data.</typeparam>
    /// <typeparam name="R">Type of Edge data.</typeparam>
    public class Node<T, R>
    {
        /// <summary>
        /// Index of node (use inside).
        /// </summary>
        public int Index { get; set; }
        //internal int Index { get; set; }

        /// <summary>
        /// Data of node.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// List of neighboring nodes (nodes connected by the edge).
        /// </summary>
        public List<Node<T, R>> Neighbors { get; set; } = new List<Node<T, R>>();

        /// <summary>
        /// Weight of edge, from this to neighboring nodes.
        /// </summary>
        public List<int> Weights { get; set; } = new List<int>();

        /// <summary>
        /// Data in edge to neighboring nodes 
        /// </summary>
        public List<R> EdgeData { get; set; } = new List<R>();

        /// <summary>
        /// Method to converting this object to string.
        /// </summary>
        /// <returns>String of Node object.</returns>
        public override string ToString()
        {
            return $"Node id { Index }, data: { Data }, neighbors count: { Neighbors.Count }";
        }
    }
}
