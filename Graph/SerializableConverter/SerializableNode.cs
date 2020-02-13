using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    /// <summary>
    /// Represent a Node in graph. This version can be serialized.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of Node data.</typeparam>
    [System.Serializable]
    public class SerializableNode<TypeOfNodeData>
    {
        /// <summary>
        /// Data of serializable node.
        /// </summary>
        public TypeOfNodeData Data { get; set; }
    }
}
