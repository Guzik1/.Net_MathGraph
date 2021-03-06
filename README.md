# Mathematical Graph for C#/.Net
This project is a simple implement a mathematical graph library that provides stores data (with data in node and data in edge) represents on graph and algorithm to operating on this data.

## General info
### Features:
- simple to use
- generic data in node and edge
- supports weighted graph
- supports directed graph
- minimal spanning tree Kruskal and Prim algorithm (for weighted graph)
- shortest Dijkstra path algorithm (for weighted graph)
- node coloring
- traversal
- save graph system (save to file).
- graph to serializable graph and conversely converter (easy to save)!

## Setup
MathGraph available in [Nuget package](https://www.nuget.org/packages/MathGraph/). <br />
MathGraphSave available in [Nuget package](https://www.nuget.org/packages/MathGraphSave/1.0.0). <br />
Compiling bin library is located in /bin folder. <br />
Copy Graph and Priority Queue (.dll files) to your project (and GraphSave when you save graph to file).<br />

## Simple code example
Data in node and edge is int. Graph is unweighted and undirected (simple graph)
```C#
// < Type of node data, type of edge data > (isWeighted, isDirected)
Graph<int, int> graph = new Graph<int, int>();

// Add:
graph.AddNode(0);   // parameters: (data of node)
graph.AddNode(1);

graph.AddEdge(graph[0], graph[1]);  // add edge beetwen node 0 and 1
// or
graph.AddEdge(graph[0], graph[1], edgeData: 10);  // add edge beetwen node 0 and 1, and data in edge = 10

// Indexers:
Node<int, int> node0 = graph[0]; // return node from index (reference to node fields)
Edge<int, int> edge01 = graph[0, 1];  // parameters [node from, node to], return edge beetwen node 0 and 1

// Call to data:
Console.WriteLine(node0.Data);
Console.WriteLine(edge01.Data); /* or */  Console.WriteLine(graph[0, 1].Data);

// Remove:
graph.RemoveEdge(node0, graph[1]); // remove edge beetwen node 0 and 1
graph.RemoveNode(graph[0]);  /* or */  graph.RemoveNode(node0);  // node 1 becomes to node 0
```
For more information, you must view [Graph documentation](https://github.com/Guzik1/MathGraph_for_.Net/blob/master/docs/Graph/index.md). <br />
When you save a graph, view [GraphSave documentation](https://github.com/Guzik1/MathGraph_for_.Net/blob/master/docs/GraphSave/GraphSave.md).<br />
Examples available [here](https://github.com/Guzik1/MathGraph_for_.Net/tree/master/Examples).

## Built with
- .Net Core 3.1
- NUnit Framework (for testing)
- [Optymalized priority queue](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp) for c# (MIT license)

## Status
Version: Beta. <br />
This project is: in progress. We add new function, may changes existing method/class names and refactorize project code.

## License
[MIT License](https://github.com/Guzik1/.Net_MathGraph/blob/master/LICENSE) © [Sebastian Guzik](https://github.com/Guzik1).
