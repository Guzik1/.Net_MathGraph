#### [Graph](./index.md 'index')
### [Graph](./Graph.md 'Graph').[Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;')
## Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.GetMinimalSpanningTreePrim() Method
Get minimal spanning tree from graph. MST is a minimal weight connect to all node in graph. USE FOR WEIGHTED GRAPH.  
Use for high edge dense in graph, compared to node count. Edge E, node V: O(E + V log V);  
```csharp
public System.Collections.Generic.List<Graph.Edge<TypeOfNodeData,TypeOfEdgeData>> GetMinimalSpanningTreePrim();
```
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Graph.Edge&lt;](./Graph-Edge-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Edge&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfNodeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfNodeData')[,](./Graph-Edge-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Edge&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfEdgeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')[&gt;](./Graph-Edge-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Edge&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of edge including minimal spanning tree.  
