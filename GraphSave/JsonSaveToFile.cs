using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GraphSave
{
    /// <summary>
    /// This class is using to load and save, serializable graph, to json text file. Implement ISavable interface.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    public class JsonSaveToFile<TypeOfNodeData, TypeOfEdgeData> : DiscGraphSave, ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Inicjalize JSON text save to file and load from file.
        /// </summary>
        /// <param name="filePath">Set file path to save/load.</param>
        public JsonSaveToFile(string filePath) : base(filePath) { }

        /// <summary>
        /// Load serializable grap from json text file.
        /// </summary>
        /// <returns>Serializable graph loaded from json text file.</returns>
        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            string jsonString = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<SerializableGraph<TypeOfNodeData, TypeOfEdgeData>>(jsonString);
        }

        /// <summary>
        /// Save serializabe graph to json text file.
        /// </summary>
        /// <param name="save">Serializable graph to save on disc.</param>
        public void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            string jsonString = JsonSerializer.Serialize(save);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
