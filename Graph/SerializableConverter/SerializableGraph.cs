using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    /// <summary>
    /// This class represent a mathematical graph with data in nodes and edges. This version can be serialized.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of data in nodes.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of data in edges.</typeparam>
    [System.Serializable]
    public class SerializableGraph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Return true when graph is directed or otherwise return false.
        /// </summary>
        public bool IsDirected { get; set; }

        /// <summary>
        /// Return true when graph is weighted or otherwise return false.
        /// </summary>
        public bool IsWeighted { get; set; }

        /// <summary>
        /// List of node from graph.
        /// </summary>
        public List<SerializableNode<TypeOfNodeData>> Node { get; set; }

        /// <summary>
        /// List of edge from graph.
        /// </summary>
        public List<SerializableEdge<TypeOfEdgeData>> Edge { get; set; }
    }
}
