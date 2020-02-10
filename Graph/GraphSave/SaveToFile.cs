using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Graph.ToSerialize;

namespace GraphSave
{
    public class SaveToFile<TypeOfNodeData, TypeOfEdgeData> : ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        string path;

        public SaveToFile(string path) =>
            this.path = path;

        public void ChangeDirectory(string path) =>
            this.path = path;

        public SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists(path))
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

                return (SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData>) formatter.Deserialize(stream);
            }

            throw new IOException("File doesn't exist in path: " + path);
        }

        public void Save(SerializableGraphDataModel<TypeOfNodeData, TypeOfEdgeData> save)
        {
            IFormatter formatter = new BinaryFormatter();
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, save);
            stream.Close();
        }
    }
}
