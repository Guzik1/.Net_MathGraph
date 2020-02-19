using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Get minimal spanning tree from graph. MST is a minimal weight connect to all node in graph. USE FOR WEIGHTED GRAPH.
        /// Use for high edge dense in graph, compared to node count. Edge E, node V: O(E + V log V);
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

            for (int i = 0; i < graph.NodesCount - 1; i++)
            {
                int minWeightIndex = GetMinimumEdgeWeightIndex();
                isInMinimalSpanningTree[minWeightIndex] = true;

                CheckEdgesAndUpdate(minWeightIndex);
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

        int GetMinimumEdgeWeightIndex()
        {
            int minValue = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < graph.NodesCount; i++)
            {
                if (IndexIsNotInMinimalSpanningTreeAndWeightIsSmaller(i, minValue))
                {
                    minValue = minWeight[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        bool IndexIsNotInMinimalSpanningTreeAndWeightIsSmaller(int index, int value)
            => !isInMinimalSpanningTree[index] && value > minWeight[index];

        void CheckEdgesAndUpdate(int minWeightIndex)
        {
            Edge<TypeOfNodeData, TypeOfEdgeData> edge;
            for (int j = 0; j < graph.NodesCount; j++)
            {
                edge = graph[minWeightIndex, j];

                if (edge != null)
                {
                    int weight = edge.Weight;

                    WhenEdgeIsNotInMSTandWeightLessUpdate(j, weight, minWeightIndex);
                }
            }
        }

        void WhenEdgeIsNotInMSTandWeightLessUpdate(int nodeToIndex, int weight, int minWeightIndex)
        {
            if (!isInMinimalSpanningTree[nodeToIndex] && weight < minWeight[nodeToIndex])
            {
                previous[nodeToIndex] = minWeightIndex;
                minWeight[nodeToIndex] = weight;
            }
        }

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
