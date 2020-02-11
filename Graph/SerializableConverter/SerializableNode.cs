using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.SerializableConverter
{
    [System.Serializable]
    public class SerializableNode<TypeOfNodeData>
    {
        public TypeOfNodeData Data { get; set; }
    }
}
