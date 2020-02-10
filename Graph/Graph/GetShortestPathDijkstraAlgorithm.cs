using Priority_Queue;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Algorithm to get a short Dijkstra path.
        /// </summary>
        /// <param name="source">Source node to start of the path.</param>
        /// <param name="target">Destination node to end of the path.</param>
        /// <returns></returns>
        public List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetShortestPathDijkstraAlgorithm(Node<TypeOfNodeData, TypeOfEdgeData> source, Node<TypeOfNodeData, TypeOfEdgeData> target)
        {
            int[] previous = new int[Nodes.Count];
            Fill(previous, -1);

            int[] distances = new int[Nodes.Count];
            Fill(distances, int.MaxValue);
            distances[source.Index] = 0;

            SimplePriorityQueue<Node<TypeOfNodeData, TypeOfEdgeData>> nodes = new SimplePriorityQueue<Node<TypeOfNodeData, TypeOfEdgeData>>();

            for (int i = 0; i < Nodes.Count; i++)
                nodes.Enqueue(Nodes[i], distances[i]);

            while(nodes.Count != 0)
            {
                Node<TypeOfNodeData, TypeOfEdgeData> node = nodes.Dequeue();

                for(int i = 0; i < node.Neighbors.Count; i++)
                {
                    Node<TypeOfNodeData, TypeOfEdgeData> neighbor = node.Neighbors[i];

                    int weight = i < node.Weights.Count ? node.Weights[i] : 0;
                    int weightTotal = distances[node.Index] + weight;

                    if(distances[neighbor.Index] > weightTotal)
                    {
                        distances[neighbor.Index] = weightTotal;

                        previous[neighbor.Index] = node.Index;

                        nodes.UpdatePriority(neighbor, distances[neighbor.Index]);
                    }
                }
            }

            List<int> indices = new List<int>();

            int index = target.Index;

            while(index >= 0)
            {
                indices.Add(index);
                index = previous[index];
            }

            indices.Reverse();

            List<Edge<TypeOfNodeData, TypeOfEdgeData>> result = new List<Edge<TypeOfNodeData, TypeOfEdgeData>>();

            for(int i = 0; i < indices.Count - 1; i++)
            {
                Edge<TypeOfNodeData, TypeOfEdgeData> edge = this[indices[i], indices[i + 1]];

                result.Add(edge);
            }

            return result;
        }

        void Fill<Q>(Q[] array, Q value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;
                
            //Parallel.For(0, array.Length, i => array[i] = value);
        }
    }
}
