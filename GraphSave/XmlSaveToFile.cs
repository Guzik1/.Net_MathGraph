using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GraphSave
{
    public class XmlSaveToFile<TypeOfNodeData, TypeOfEdgeData> : ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        string filePath;

        public XmlSaveToFile(string filePath) =>
            this.filePath = filePath;

        public void ChangeDirectory(string filePath) =>
            this.filePath = filePath;

        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            TextReader reader = null;

            try
            {
                var serializer = new XmlSerializer(typeof(SerializableGraph<TypeOfNodeData, TypeOfEdgeData>));
                reader = new StreamReader(filePath);
                return (SerializableGraph<TypeOfNodeData, TypeOfEdgeData>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save)
        {
            TextWriter writer = null;

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            try
            {
                var serializer = new XmlSerializer(typeof(SerializableGraph<TypeOfNodeData, TypeOfEdgeData>));
                writer = new StreamWriter(filePath);
                serializer.Serialize(writer, save);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
