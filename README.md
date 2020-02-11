# Mathematical Graph for C#/.Net
This is a simple implement a mathematical graph library that provides stores data(with data in node and data in edge) represents on graph and algorithm to operating on this data.

## General info
### Features:
- simple to use
- generic data in node and edge
- supports weighted graph
- supports directed graph
- shortest Dijkstra path algorithm (for weighted graph)
- save graph system
- graph to serializable graph and conversely converter (easy to save)!

## Setup
Compiling bin library in /bin folder. <br />
Copy Graph and Priority Queue (.dll files) to your project. <br />
NuGet package available soon.

## Simple code example
Data in node and edge is int. Graph is unweighted and undirected (simple graph)
```C#
// < Type of node data, type of edge data >
Graph<int, int> graph = new Graph<int, int>();

// Add:
graph.AddNode(0);   // parameters: (data of node)
graph.AddNode(1);

graph.AddEdge(graph[0], graph[1]);  // add edge beetwen node 0 and 1
// or
graph.AddEdge(graph[0], graph[1], edgeData: 10);  // add edge beetwen node 0 and 1, and data in edge = 10

// Indexers:
Node<int, int> node0 = graph[0]; // return node from index
Edge<int, int> edge01 = graph[0, 1];  // parameters [node from, node to], return edge beetwen node 0 and 1

// Call to data:
Console.WriteLine(node0.Data);
Console.WriteLine(edge01.Data);

// Remove:
graph.RemoveEdge(node0, graph[1]); // remove edge beetwen node 0 and 1
graph.RemoveNode(graph[0]);  /* or */  graph.RemoveNode(node0);  // node 1 becomes to node 0
```
For more info and examples, you must view documentation.

## Built with
- .Net Core 3.0
- NUnit Framework (for testing)
- [Optymalized priority queue](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp) for c# (MIT license)

## Status
This project is: in progress. We add new function and may changes existing method/class.

## License
[MIT License](https://github.com/Guzik1/.Net_MathGraph/blob/master/LICENSE) © [Sebastian Guzik](https://github.com/Guzik1).
