using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSave
{
    public interface ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save);

        SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load();
    }
}
