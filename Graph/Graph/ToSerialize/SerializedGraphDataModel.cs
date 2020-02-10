using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.ToSerialize
{
    [System.Serializable]
    public class SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData>
    {
        public bool IsDirected { get; set; }
        public bool IsWeighted { get; set; }

        public List<SerializedNode<TypeOfNodeData>> Node { get; set; }

        public List<SerializedEdge<TypeOfEdgeData>> Edge { get; set; }
    }
}
