#### [GraphSave](./index.md 'index')
### [GraphSave](./GraphSave.md 'GraphSave')
## BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt; Class
This class is using to load and save, serializable graph, to binary file. Implement ISavable interface.  
```csharp
public class BinarySaveToFile<TypeOfNodeData,TypeOfEdgeData> : DiscGraphSave,
ISavable<TypeOfNodeData, TypeOfEdgeData>
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &gt; [DiscGraphSave](./GraphSave-DiscGraphSave.md 'GraphSave.DiscGraphSave') &gt; [BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;](./GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  

Implements [GraphSave.ISavable&lt;](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfNodeData](#GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData 'GraphSave.BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfNodeData')[,](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfEdgeData](#GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'GraphSave.BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')[&gt;](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  
#### Type parameters
<a name='GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData'></a>
`TypeOfNodeData`  
Type of node data.  
  
<a name='GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData'></a>
`TypeOfEdgeData`  
Type of edge data.  
  
### Constructors
- [BinarySaveToFile(string)](./GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--BinarySaveToFile(string).md 'GraphSave.BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.BinarySaveToFile(string)')
### Methods
- [Load()](./GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--Load().md 'GraphSave.BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Load()')
- [Save(Graph.SerializableConverter.SerializableGraph&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./GraphSave-BinarySaveToFile-TypeOfNodeData_TypeOfEdgeData--Save(Graph-SerializableConverter-SerializableGraph-TypeOfNodeData_TypeOfEdgeData-).md 'GraphSave.BinarySaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Save(Graph.SerializableConverter.SerializableGraph&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
