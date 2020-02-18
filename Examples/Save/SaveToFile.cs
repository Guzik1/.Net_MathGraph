using System;
using System.Collections.Generic;
using System.Text;
using Graph;
using Graph.SerializableConverter;
using GraphSave;

namespace Examples.Save
{
    public class SaveToFile
    {
        Graph<int, int> graph = new Graph<int, int>();

        SerializableGraphConverter<int, int> converter;
        SerializableGraph<int, int> serializableGraph;

        ISavable<int, int> saver;

        string filePath = @"C:/test/test";

        void Example()
        {
            // ** Inicjalize graph
            graph.AddNode(51);
            graph.AddNode(12);

            graph.AddEdge(graph[0], graph[1]);
            // ** End inicjalize

            converter = new SerializableGraphConverter<int, int>(graph);

            serializableGraph = converter.GetSerializableGraph();

            saver = new BinarySaveToFile<int, int>(filePath + ".bin");  // bin file or
            saver = new JsonSaveToFile<int, int>(filePath + ".json");   // json text file or
            saver = new XmlSaveToFile<int, int>(filePath + ".xml");     // xml file

            saver.Save(serializableGraph);  // Save to file.

            serializableGraph = saver.Load();  // Load from file.
        }
    }
}
