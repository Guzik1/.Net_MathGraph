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
        string path;

        public XmlSaveToFile(string path) =>
            this.path = path;

        public void ChangeDirectory(string path) =>
            this.path = path;

        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(SerializableGraph<TypeOfNodeData, TypeOfEdgeData>));
                reader = new StreamReader(path);
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

            try
            {
                var serializer = new XmlSerializer(typeof(SerializableGraph<TypeOfNodeData, TypeOfEdgeData>));
                writer = new StreamWriter(path);
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
