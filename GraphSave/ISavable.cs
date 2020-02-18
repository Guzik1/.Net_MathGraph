using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSave
{
    /// <summary>
    /// Implement this interface for using to load and save serializable graph to file.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    public interface ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Save serializable graph to file.
        /// </summary>
        /// <param name="save">Serializable graph data to save.</param>
        void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save);

        /// <summary>
        /// Load serializable graph from file.
        /// </summary>
        /// <returns>Serializable graph.</returns>
        SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load();
    }
}
