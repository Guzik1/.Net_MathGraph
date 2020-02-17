using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Graph.SerializableConverter;

namespace GraphSave
{
    public class BinarySaveToFile<TypeOfNodeData, TypeOfEdgeData> : ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        string path;

        public BinarySaveToFile(string path) =>
            this.path = path;

        public void ChangeDirectory(string path) =>
            this.path = path;

        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists(path))
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

                object output = formatter.Deserialize(stream);

                stream.Close();

                return (SerializableGraph<TypeOfNodeData, TypeOfEdgeData>)output;
            }

            throw new IOException("File doesn't exist in path: " + path);
        }

        public void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save)
        {
            IFormatter formatter = new BinaryFormatter();
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, save);
            stream.Close();
        }
    }
}
