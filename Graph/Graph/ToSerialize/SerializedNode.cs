using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.ToSerialize
{
    [System.Serializable]
    public class SerializedNode<TypeOfNodeData>
    {
        //public int Index { get; set; }

        public TypeOfNodeData Data { get; set; }

        //public List<int> NeighborsId { get; set; }
    }
}
