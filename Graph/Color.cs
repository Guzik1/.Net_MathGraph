using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Color a graph nodes. Get a color numbers for nodes in graph.
        /// </summary>
        /// <returns>Array of color number for index node.</returns>
        public int[] GetColors()
        {
            Color<TypeOfNodeData, TypeOfEdgeData> color = new Color<TypeOfNodeData, TypeOfEdgeData>(this);

            return color.GetColors();
        }
    }

    internal class Color<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        int[] colors;
        bool[] availability;
        int colorIndex = 0;

        internal Color(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        internal int[] GetColors()
        {
            Inicjalize();

            for(int i = 1; i < graph.NodesCount; i++)
            {
                Fill(availability, true);

                CheckColorAvailability(i);

                SetColorToCurrenNode(i);
            }

            return colors;
        }

        void Inicjalize()
        {
            colors = new int[graph.NodesCount];
            Fill(colors, -1);
            colors[0] = 0;

            availability = new bool[graph.NodesCount];
        }

        void CheckColorAvailability(int nodeIndex)
        {
            foreach (Node<TypeOfNodeData, TypeOfEdgeData> neighbor in graph[nodeIndex].Neighbors)
            {
                colorIndex = colors[neighbor.Index];
                if (colorIndex >= 0)
                {
                    availability[colorIndex] = false;
                }
            }

            colorIndex = 0;
        }

        void SetColorToCurrenNode(int nodeIndex)
        {
            colorIndex = 0;
            for (int j = 0; j < availability.Length; j++)
            {
                if (availability[j])
                {
                    colorIndex = j;
                    break;
                }
            }

            colors[nodeIndex] = colorIndex;
        }

        void Fill<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;

            //Parallel.For(0, array.Length, i => array[i] = value);
        }
    }
}
