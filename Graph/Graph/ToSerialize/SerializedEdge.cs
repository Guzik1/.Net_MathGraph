using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.ToSerialize
{
    [System.Serializable]
    public class SerializedEdge<TypeOfEdgeData>
    {
        public int NodeFromId { get; set; }

        public int NodeToId { get; set; }

        public TypeOfEdgeData Data { get; set; }

        public int Weight { get; set; }
    }
}
