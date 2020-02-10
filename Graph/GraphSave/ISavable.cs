using Graph.ToSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSave
{
    public interface ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        void Save(SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData> save);

        SerializedGraphDataModel<TypeOfNodeData, TypeOfEdgeData> Load();
    }
}
