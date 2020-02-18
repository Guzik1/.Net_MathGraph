using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Get minimal spanning tree from graph. MST is a minimal weight connect to all node in graph.
        /// Use for high edge dense in graph, compared to node count. Edge is E, node V: O(E + V log V);
        /// </summary>
        /// <returns>List of edge including minimal spanning tree.</returns>
        public List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetMinimalSpanningTreePrim()
        {
            MinimalSpanningTreePrim<TypeOfNodeData, TypeOfEdgeData> mstp = new MinimalSpanningTreePrim<TypeOfNodeData, TypeOfEdgeData>(this);

            return mstp.PrimAlgorithm();
        }
    }

    internal class MinimalSpanningTreePrim<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        int[] previous;
        int[] minWeight;
        bool[] isInMinimalSpanningTree;

        List<Edge<TypeOfNodeData, TypeOfEdgeData>> result = new List<Edge<TypeOfNodeData, TypeOfEdgeData>>();

        internal MinimalSpanningTreePrim(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        internal List<Edge<TypeOfNodeData, TypeOfEdgeData>> PrimAlgorithm()
        {
            InicjalizeAlgorithm();

            for(int i = 0; i < graph.NodesCount - 1; i++)
            {
                int minWeightIndex = GetMinimumWeightIndex();
                isInMinimalSpanningTree[minWeightIndex] = true;

                Edge<TypeOfNodeData, TypeOfEdgeData> edge;
                for (int j = 0; j < graph.NodesCount; j++)
                {
                    edge = graph[minWeightIndex, j];

                    int weight = edge != null ? edge.Weight : -1;

                    if(edge != null && !isInMinimalSpanningTree[j] && weight < minWeight[j])
                    {
                        previous[j] = minWeightIndex;
                        minWeight[j] = weight;
                    }
                }
            }

            BuildResault();

            return result;
        }

        void InicjalizeAlgorithm()
        {
            previous = new int[graph.NodesCount];
            previous[0] = -1;

            minWeight = new int[graph.NodesCount];
            Fill(minWeight, int.MaxValue);
            minWeight[0] = 0;

            isInMinimalSpanningTree = new bool[graph.NodesCount];
            Fill(isInMinimalSpanningTree, false);
        }

        int GetMinimumWeightIndex()
        {
            int minValue = int.MaxValue;
            int minIndex = 0;

            for(int i = 0; i < graph.NodesCount; i++)
            {
                if(IndexIsntInMinimalSpanningTreeAndWeightIsSmaller(i, minValue))
                {
                    minValue = minWeight[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        bool IndexIsntInMinimalSpanningTreeAndWeightIsSmaller(int index, int value)
            => !isInMinimalSpanningTree[index] && value > minWeight[index];

        void BuildResault()
        {
            for (int i = 1; i < graph.NodesCount; i++)
            {
                Edge<TypeOfNodeData, TypeOfEdgeData> edge = graph[previous[i], i];
                result.Add(edge);
            }
        }

        void Fill<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;

            //Parallel.For(0, array.Length, i => array[i] = value);
        }
    } 
}
