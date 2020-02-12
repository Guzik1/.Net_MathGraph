<a name='assembly'></a>
# Graph

## Contents

- [Edge\`2](#T-Graph-Edge`2 'Graph.Edge`2')
  - [Data](#P-Graph-Edge`2-Data 'Graph.Edge`2.Data')
  - [From](#P-Graph-Edge`2-From 'Graph.Edge`2.From')
  - [To](#P-Graph-Edge`2-To 'Graph.Edge`2.To')
  - [Weight](#P-Graph-Edge`2-Weight 'Graph.Edge`2.Weight')
  - [ToString()](#M-Graph-Edge`2-ToString 'Graph.Edge`2.ToString')
- [Graph\`2](#T-Graph-Graph`2 'Graph.Graph`2')
  - [#ctor(isDirected,isWeighted)](#M-Graph-Graph`2-#ctor-System-Boolean,System-Boolean- 'Graph.Graph`2.#ctor(System.Boolean,System.Boolean)')
  - [#ctor(isWeighted)](#M-Graph-Graph`2-#ctor-System-Boolean- 'Graph.Graph`2.#ctor(System.Boolean)')
  - [#ctor()](#M-Graph-Graph`2-#ctor 'Graph.Graph`2.#ctor')
  - [IsDirected](#P-Graph-Graph`2-IsDirected 'Graph.Graph`2.IsDirected')
  - [IsWeighted](#P-Graph-Graph`2-IsWeighted 'Graph.Graph`2.IsWeighted')
  - [Item](#P-Graph-Graph`2-Item-System-Int32,System-Int32- 'Graph.Graph`2.Item(System.Int32,System.Int32)')
  - [Item](#P-Graph-Graph`2-Item-System-Int32- 'Graph.Graph`2.Item(System.Int32)')
  - [NodesCount](#P-Graph-Graph`2-NodesCount 'Graph.Graph`2.NodesCount')
  - [AddEdge(from,to,weight,edgeData)](#M-Graph-Graph`2-AddEdge-Graph-Node{`0,`1},Graph-Node{`0,`1},System-Int32,`1- 'Graph.Graph`2.AddEdge(Graph.Node{`0,`1},Graph.Node{`0,`1},System.Int32,`1)')
  - [AddNode(value)](#M-Graph-Graph`2-AddNode-`0- 'Graph.Graph`2.AddNode(`0)')
  - [GetAllEdges()](#M-Graph-Graph`2-GetAllEdges 'Graph.Graph`2.GetAllEdges')
  - [GetShortestPathDijkstraAlgorithm(source,target)](#M-Graph-Graph`2-GetShortestPathDijkstraAlgorithm-Graph-Node{`0,`1},Graph-Node{`0,`1}- 'Graph.Graph`2.GetShortestPathDijkstraAlgorithm(Graph.Node{`0,`1},Graph.Node{`0,`1})')
  - [RemoveEdge(from,to)](#M-Graph-Graph`2-RemoveEdge-Graph-Node{`0,`1},Graph-Node{`0,`1}- 'Graph.Graph`2.RemoveEdge(Graph.Node{`0,`1},Graph.Node{`0,`1})')
  - [RemoveNode(nodeToRemove)](#M-Graph-Graph`2-RemoveNode-Graph-Node{`0,`1}- 'Graph.Graph`2.RemoveNode(Graph.Node{`0,`1})')
- [Node\`2](#T-Graph-Node`2 'Graph.Node`2')
  - [Data](#P-Graph-Node`2-Data 'Graph.Node`2.Data')
  - [EdgeData](#P-Graph-Node`2-EdgeData 'Graph.Node`2.EdgeData')
  - [Index](#P-Graph-Node`2-Index 'Graph.Node`2.Index')
  - [Neighbors](#P-Graph-Node`2-Neighbors 'Graph.Node`2.Neighbors')
  - [Weights](#P-Graph-Node`2-Weights 'Graph.Node`2.Weights')
  - [ToString()](#M-Graph-Node`2-ToString 'Graph.Node`2.ToString')

<a name='T-Graph-Edge`2'></a>
## Edge\`2 `type`

##### Namespace

Graph

##### Summary

Object repersent a edge from graph.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of node data. |
| R | Type of edge data. |

<a name='P-Graph-Edge`2-Data'></a>
### Data `property`

##### Summary

Edge data.

<a name='P-Graph-Edge`2-From'></a>
### From `property`

##### Summary

The start node.

<a name='P-Graph-Edge`2-To'></a>
### To `property`

##### Summary

The end node.

<a name='P-Graph-Edge`2-Weight'></a>
### Weight `property`

##### Summary

Edge weight

<a name='M-Graph-Edge`2-ToString'></a>
### ToString() `method`

##### Summary

Convert this object to string.

##### Returns

String of object

##### Parameters

This method has no parameters.

<a name='T-Graph-Graph`2'></a>
## Graph\`2 `type`

##### Namespace

Graph

##### Summary

This class represent a mathematical graph with data in nodes and edges.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TypeOfNodeData | Type of data in nodes. |
| TypeOfEdgeData | Type of data in edges. |

<a name='M-Graph-Graph`2-#ctor-System-Boolean,System-Boolean-'></a>
### #ctor(isDirected,isWeighted) `constructor`

##### Summary

Inicjalize weighted and directed graph, select graph directed and weighted type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isDirected | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set true to direct a graph, for undirected set false. |
| isWeighted | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set true to weighted a edge, for unwegihted set false. |

<a name='M-Graph-Graph`2-#ctor-System-Boolean-'></a>
### #ctor(isWeighted) `constructor`

##### Summary

Inicjalize weighted graph, select graph weighted type. (Set isDirected to false)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isWeighted | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set true to weighted a edge, for unwegihted set false. |

<a name='M-Graph-Graph`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Inicjalize standard graph, unweighted and undirected.

##### Parameters

This constructor has no parameters.

<a name='P-Graph-Graph`2-IsDirected'></a>
### IsDirected `property`

##### Summary

Return true when graph is directed or otherwise false

<a name='P-Graph-Graph`2-IsWeighted'></a>
### IsWeighted `property`

##### Summary

Return true when graph is weighted or otherwise false

<a name='P-Graph-Graph`2-Item-System-Int32,System-Int32-'></a>
### Item `property`

##### Summary

Get the edge between two nodes (from, to).

##### Returns

Edge between node FROM and node TO.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Edge FROM the node. |
| to | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Edge TO the node. |

<a name='P-Graph-Graph`2-Item-System-Int32-'></a>
### Item `property`

##### Summary

Get the node from node number.

##### Returns

Node

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nodeNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of node. |

<a name='P-Graph-Graph`2-NodesCount'></a>
### NodesCount `property`

##### Summary

Get nodes count in graph.

##### Returns

Nodes count

<a name='M-Graph-Graph`2-AddEdge-Graph-Node{`0,`1},Graph-Node{`0,`1},System-Int32,`1-'></a>
### AddEdge(from,to,weight,edgeData) `method`

##### Summary

Add edge between two node (from, to) and/or weight and/or data in edge.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Node from edge start. |
| to | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Node to edge end. |
| weight | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Weight of edge, default 0 (use for weighted graph) |
| edgeData | [\`1](#T-`1 '`1') | The edge data, default 'default of data'. |

<a name='M-Graph-Graph`2-AddNode-`0-'></a>
### AddNode(value) `method`

##### Summary

Add node to graph.

##### Returns

Return added node to list of all nodes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Data in node. |

<a name='M-Graph-Graph`2-GetAllEdges'></a>
### GetAllEdges() `method`

##### Summary

Get all of edge in graph.

##### Returns

List of all edges in graph.

##### Parameters

This method has no parameters.

<a name='M-Graph-Graph`2-GetShortestPathDijkstraAlgorithm-Graph-Node{`0,`1},Graph-Node{`0,`1}-'></a>
### GetShortestPathDijkstraAlgorithm(source,target) `method`

##### Summary

Algorithm to get a short Dijkstra path.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Source node to start of the path. |
| target | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Destination node to end of the path. |

<a name='M-Graph-Graph`2-RemoveEdge-Graph-Node{`0,`1},Graph-Node{`0,`1}-'></a>
### RemoveEdge(from,to) `method`

##### Summary

Remove a edge between node FROM and node TO.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Node of start edge. |
| to | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Node of end edge. |

<a name='M-Graph-Graph`2-RemoveNode-Graph-Node{`0,`1}-'></a>
### RemoveNode(nodeToRemove) `method`

##### Summary

Remove node from the graph.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nodeToRemove | [Graph.Node{\`0,\`1}](#T-Graph-Node{`0,`1} 'Graph.Node{`0,`1}') | Node to remove. |

<a name='T-Graph-Node`2'></a>
## Node\`2 `type`

##### Namespace

Graph

##### Summary

Represent a Node in graph.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of Node data. |
| R | Type of Edge data. |

<a name='P-Graph-Node`2-Data'></a>
### Data `property`

##### Summary

Data of node.

<a name='P-Graph-Node`2-EdgeData'></a>
### EdgeData `property`

##### Summary

Data in edge to neighboring nodes

<a name='P-Graph-Node`2-Index'></a>
### Index `property`

##### Summary

Index of node (use inside).

<a name='P-Graph-Node`2-Neighbors'></a>
### Neighbors `property`

##### Summary

List of neighboring nodes (nodes connected by the edge).

<a name='P-Graph-Node`2-Weights'></a>
### Weights `property`

##### Summary

Weight of edge, from this to neighboring nodes.

<a name='M-Graph-Node`2-ToString'></a>
### ToString() `method`

##### Summary

Method to converting this object to string.

##### Returns

String of Node object.

##### Parameters

This method has no parameters.
