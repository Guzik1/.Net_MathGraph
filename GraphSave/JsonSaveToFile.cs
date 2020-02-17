using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GraphSave
{
    public class JsonSaveToFile<TypeOfNodeData, TypeOfEdgeData> : ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        string filePath;

        public JsonSaveToFile(string filePath) =>
            this.filePath = filePath;

        public void ChangeDirectory(string filePath) =>
            this.filePath = filePath;


        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            string jsonString = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<SerializableGraph<TypeOfNodeData, TypeOfEdgeData>>(jsonString);
        }

        public void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            string jsonString = JsonSerializer.Serialize(save);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
