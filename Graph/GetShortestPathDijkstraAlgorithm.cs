using Priority_Queue;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public partial class Graph<TypeOfNodeData, TypeOfEdgeData>
    {
        /// <summary>
        /// Algorithm to get a short Dijkstra path. USE FOR WEIGHTED GRAPH.
        /// </summary>
        /// <param name="source">Source node to start of the path.</param>
        /// <param name="target">Destination node to end of the path.</param>
        /// <returns></returns>
        public List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetShortestPathDijkstraAlgorithm(Node<TypeOfNodeData, TypeOfEdgeData> source, Node<TypeOfNodeData, TypeOfEdgeData> target)
        {
            ShortestPathDijkstra<TypeOfNodeData, TypeOfEdgeData> shortedPath = new ShortestPathDijkstra<TypeOfNodeData, TypeOfEdgeData>(this);

            return shortedPath.GetShortestPathDijkstra(source, target);
        }
    }

    internal class ShortestPathDijkstra<TypeOfNodeData, TypeOfEdgeData>
    {
        Graph<TypeOfNodeData, TypeOfEdgeData> graph;

        internal ShortestPathDijkstra(Graph<TypeOfNodeData, TypeOfEdgeData> graph)
            => this.graph = graph;

        int[] previous;
        int[] distances;

        Node<TypeOfNodeData, TypeOfEdgeData> source;
        Node<TypeOfNodeData, TypeOfEdgeData> target;

        SimplePriorityQueue<Node<TypeOfNodeData, TypeOfEdgeData>> nodes = new SimplePriorityQueue<Node<TypeOfNodeData, TypeOfEdgeData>>();

        internal List<Edge<TypeOfNodeData, TypeOfEdgeData>> GetShortestPathDijkstra(Node<TypeOfNodeData, TypeOfEdgeData> source, Node<TypeOfNodeData, TypeOfEdgeData> target)
        {
            this.source = source;
            this.target = target;

            Inicjalize();

            // For performance, don't refactor this loop;
            Node<TypeOfNodeData, TypeOfEdgeData> node;
            Node<TypeOfNodeData, TypeOfEdgeData> neighbor;
            while (nodes.Count != 0)
            {
                node = nodes.Dequeue();

                for (int i = 0; i < node.Neighbors.Count; i++)
                {
                    neighbor = node.Neighbors[i];

                    int weight = i < node.Weights.Count ? node.Weights[i] : 0;
                    int weightTotal = distances[node.Index] + weight;

                    if (distances[neighbor.Index] > weightTotal)
                    {
                        distances[neighbor.Index] = weightTotal;

                        previous[neighbor.Index] = node.Index;

                        nodes.UpdatePriority(neighbor, distances[neighbor.Index]);
                    }
                }
            }

            return BuildResult();
        }

        void Inicjalize()
        {
            previous = new int[graph.NodesCount];
            distances = new int[graph.NodesCount];

            Fill(previous, -1);
            Fill(distances, int.MaxValue);

            distances[source.Index] = 0;

            for (int i = 0; i < graph.NodesCount; i++)
                nodes.Enqueue(graph[i], distances[i]);
        }

        List<Edge<TypeOfNodeData, TypeOfEdgeData>> BuildResult()
        {
            List<int> indices = new List<int>();

            int index = target.Index;

            while (index >= 0)
            {
                indices.Add(index);
                index = previous[index];
            }

            indices.Reverse();

            List<Edge<TypeOfNodeData, TypeOfEdgeData>> result = new List<Edge<TypeOfNodeData, TypeOfEdgeData>>();

            for (int i = 0; i < indices.Count - 1; i++)
            {
                Edge<TypeOfNodeData, TypeOfEdgeData> edge = graph[indices[i], indices[i + 1]];

                result.Add(edge);
            }

            return result;
        }

        void Fill<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;

            //Parallel.For(0, array.Length, i => array[i] = value);
        }
    }
}
