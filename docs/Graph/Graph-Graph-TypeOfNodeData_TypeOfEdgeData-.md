#### [Graph](./index.md 'index')
### [Graph](./Graph.md 'Graph')
## Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt; Class
Represent a mathematical graph with data in nodes and edges. This version can't be serialized.  
```csharp
public class Graph<TypeOfNodeData,TypeOfEdgeData>
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &gt; [Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  
#### Type parameters
<a name='Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData'></a>
`TypeOfNodeData`  
Type of data in nodes.  
  
<a name='Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData'></a>
`TypeOfEdgeData`  
Type of data in edges.  
  
### Constructors
- [Graph()](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--Graph().md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Graph()')
- [Graph(bool)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--Graph(bool).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Graph(bool)')
- [Graph(bool, bool)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--Graph(bool_bool).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Graph(bool, bool)')
### Properties
- [IsDirected](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--IsDirected.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.IsDirected')
- [IsWeighted](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--IsWeighted.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.IsWeighted')
- [this[int]](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--this-int-.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.this[int]')
- [this[int, int]](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--this-int_int-.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.this[int, int]')
- [NodesCount](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--NodesCount.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.NodesCount')
### Methods
- [AddEdge(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, int, TypeOfEdgeData)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--AddEdge(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-_int_TypeOfEdgeData).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.AddEdge(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, int, TypeOfEdgeData)')
- [AddNode(TypeOfNodeData)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--AddNode(TypeOfNodeData).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.AddNode(TypeOfNodeData)')
- [GetAllEdges()](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--GetAllEdges().md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetAllEdges()')
- [GetBreadthFirstSearch(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--GetBreadthFirstSearch(Graph-Node-TypeOfNodeData_TypeOfEdgeData-).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetBreadthFirstSearch(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
- [GetDepthFirstSearch(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--GetDepthFirstSearch(Graph-Node-TypeOfNodeData_TypeOfEdgeData-).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetDepthFirstSearch(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
- [GetMinimalSpanningTreeKruskal()](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--GetMinimalSpanningTreeKruskal().md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetMinimalSpanningTreeKruskal()')
- [GetMinimalSpanningTreePrim()](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--GetMinimalSpanningTreePrim().md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetMinimalSpanningTreePrim()')
- [GetShortestPathDijkstraAlgorithm(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--GetShortestPathDijkstraAlgorithm(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetShortestPathDijkstraAlgorithm(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
- [RemoveEdge(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--RemoveEdge(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.RemoveEdge(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
- [RemoveNode(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData--RemoveNode(Graph-Node-TypeOfNodeData_TypeOfEdgeData-).md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.RemoveNode(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
