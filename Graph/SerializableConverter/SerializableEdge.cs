using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    [System.Serializable]
    public class SerializableEdge<TypeOfEdgeData>
    {
        public int NodeFromId { get; set; }

        public int NodeToId { get; set; }

        public TypeOfEdgeData Data { get; set; }

        public int Weight { get; set; }
    }
}
