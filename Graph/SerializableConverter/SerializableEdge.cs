using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    /// <summary>
    /// Object repersent a edge from graph. This version can be serialized.
    /// </summary>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    [System.Serializable]
    public class SerializableEdge<TypeOfEdgeData>
    {
        /// <summary>
        /// The begin node id.
        /// </summary>
        public int NodeFromId { get; set; }

        /// <summary>
        /// The end node id.
        /// </summary>
        public int NodeToId { get; set; }

        /// <summary>
        /// Edge data.
        /// </summary>
        public TypeOfEdgeData Data { get; set; }

        /// <summary>
        /// Edge weight
        /// </summary>
        public int Weight { get; set; }
    }
}
