using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Represent a Node in graph, with id, data in node, list of neighbor, weights and edges data.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of Node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of Edge data.</typeparam>
    public class Node<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Index of node (use inside, may change when removing nodes).
        /// </summary>
        public int Index { get; set; }
        //internal int Index { get; set; }

        /// <summary>
        /// Data of node.
        /// </summary>
        public TypeOfNodeData Data { get; set; }

        /// <summary>
        /// List of neighboring nodes (nodes connected by the edge).
        /// </summary>
        public List<Node<TypeOfNodeData, TypeOfEdgeData>> Neighbors { get; set; } = new List<Node<TypeOfNodeData, TypeOfEdgeData>>();

        /// <summary>
        /// Weight of edge, from this node to neighboring nodes.
        /// </summary>
        public List<int> Weights { get; set; } = new List<int>();

        /// <summary>
        /// Data edge from this node to neighboring nodes.
        /// </summary>
        public List<TypeOfEdgeData> EdgeData { get; internal set; } = new List<TypeOfEdgeData>();

        /// <summary>
        /// Convert this object to string.
        /// Converting format:
        /// </summary>
        /// <code>return $"Node id { Index }, data: { Data }, neighbors count: { Neighbors.Count }"</code>
        /// <returns>String of Node object.</returns>
        public override string ToString()
        {
            return $"Node id { Index }, data: { Data }, neighbors count: { Neighbors.Count }";
        }
    }
}
