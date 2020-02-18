using Graph.SerializableConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GraphSave
{    
    /// <summary>
    /// This class is using to load and save, serializable graph, to xml text file. Implement ISavable interface.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    public class XmlSaveToFile<TypeOfNodeData, TypeOfEdgeData> : DiscGraphSave, ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Inicjalize XML text save to file and load from file.
        /// </summary>
        /// <param name="filePath">Set file path to save/load.</param>
        public XmlSaveToFile(string filePath) : base(filePath) { }

        /// <summary>
        /// Load serializable grap from xml text file.
        /// </summary>
        /// <returns>Serializable graph loaded from xml text file.</returns>
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

        /// <summary>
        /// Save serializabe graph to xml text file.
        /// </summary>
        /// <param name="save">Serializable graph to save on disc.</param>
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
