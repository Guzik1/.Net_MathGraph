using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Graph.SerializableConverter;

namespace GraphSave
{
    /// <summary>
    /// This class is using to load and save, serializable graph, to binary file. Implement ISavable interface.
    /// </summary>
    /// <typeparam name="TypeOfNodeData">Type of node data.</typeparam>
    /// <typeparam name="TypeOfEdgeData">Type of edge data.</typeparam>
    public class BinarySaveToFile<TypeOfNodeData, TypeOfEdgeData> : DiscGraphSave, ISavable<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Inicjalize binary save to file and load from file.
        /// </summary>
        /// <param name="filePath">Set file path to save/load.</param>
        public BinarySaveToFile(string filePath) : base(filePath) { }

        /// <summary>
        /// Load serializable grap from bin file.
        /// </summary>
        /// <returns>Serializable graph loaded from bin file.</returns>
        public SerializableGraph<TypeOfNodeData, TypeOfEdgeData> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                object output = formatter.Deserialize(stream);

                stream.Close();

                return (SerializableGraph<TypeOfNodeData, TypeOfEdgeData>)output;
            }

            throw new IOException("File doesn't exist in path: " + filePath);
        }

        /// <summary>
        /// Save serializabe graph to binary file.
        /// </summary>
        /// <param name="save">Serializable graph to save on disc.</param>
        public void Save(SerializableGraph<TypeOfNodeData, TypeOfEdgeData> save)
        {
            IFormatter formatter = new BinaryFormatter();
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, save);
            stream.Close();
        }
    }
}
