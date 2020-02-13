#### [Graph](./index.md 'index')
### [Graph](./Graph.md 'Graph').[Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;')
## Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.AddEdge(Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;, int, TypeOfEdgeData) Method
Add edge between two node (from, to) and/or weight and/or data in edge.  
```csharp
public void AddEdge(Graph.Node<TypeOfNodeData,TypeOfEdgeData> from, Graph.Node<TypeOfNodeData,TypeOfEdgeData> to, int weight=0, TypeOfEdgeData edgeData=default(TypeOfEdgeData));
```
#### Parameters
<a name='Graph-Graph-TypeOfNodeData_TypeOfEdgeData--AddEdge(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-_int_TypeOfEdgeData)-from'></a>
`from` [Graph.Node&lt;](./Graph-Node-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfNodeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfNodeData')[,](./Graph-Node-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfEdgeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')[&gt;](./Graph-Node-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  
Node from edge start.  
  
<a name='Graph-Graph-TypeOfNodeData_TypeOfEdgeData--AddEdge(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-_int_TypeOfEdgeData)-to'></a>
`to` [Graph.Node&lt;](./Graph-Node-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfNodeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfNodeData')[,](./Graph-Node-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfEdgeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')[&gt;](./Graph-Node-TypeOfNodeData_TypeOfEdgeData-.md 'Graph.Node&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  
Node to edge end.  
  
<a name='Graph-Graph-TypeOfNodeData_TypeOfEdgeData--AddEdge(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-_int_TypeOfEdgeData)-weight'></a>
`weight` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Weight of edge, default 0 (use for weighted graph)  
  
<a name='Graph-Graph-TypeOfNodeData_TypeOfEdgeData--AddEdge(Graph-Node-TypeOfNodeData_TypeOfEdgeData-_Graph-Node-TypeOfNodeData_TypeOfEdgeData-_int_TypeOfEdgeData)-edgeData'></a>
`edgeData` [TypeOfEdgeData](./Graph-Graph-TypeOfNodeData_TypeOfEdgeData-.md#Graph-Graph-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'Graph.Graph&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')  
The edge data, default 'default of data'.  
  
