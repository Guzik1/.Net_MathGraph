using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSave
{
    public interface ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        void Save(SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> save);

        SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> Load();
    }
}
