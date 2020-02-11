using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    [System.Serializable]
    public class SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData>
    {
        public bool IsDirected { get; set; }
        public bool IsWeighted { get; set; }

        public List<SerializableNode<TypeOfNodeData>> Node { get; set; }

        public List<SerializableEdge<TypeOfEdgeData>> Edge { get; set; }
    }
}
