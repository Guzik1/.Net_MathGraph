#### [GraphSave](./index.md 'index')
### [GraphSave](./GraphSave.md 'GraphSave')
## JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt; Class
This class is using to load and save, serializable graph, to json text file. Implement ISavable interface.  
```csharp
public class JsonSaveToFile<TypeOfNodeData,TypeOfEdgeData> : DiscGraphSave,
ISavable<TypeOfNodeData, TypeOfEdgeData>
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &gt; [DiscGraphSave](./GraphSave-DiscGraphSave.md 'GraphSave.DiscGraphSave') &gt; [JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;](./GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  

Implements [GraphSave.ISavable&lt;](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfNodeData](#GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData 'GraphSave.JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfNodeData')[,](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfEdgeData](#GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'GraphSave.JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')[&gt;](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  
#### Type parameters
<a name='GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData'></a>
`TypeOfNodeData`  
Type of node data.  
  
<a name='GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData'></a>
`TypeOfEdgeData`  
Type of edge data.  
  
### Constructors
- [JsonSaveToFile(string)](./GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--JsonSaveToFile(string).md 'GraphSave.JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.JsonSaveToFile(string)')
### Methods
- [Load()](./GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--Load().md 'GraphSave.JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Load()')
- [Save(Graph.SerializableConverter.SerializableGraph&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./GraphSave-JsonSaveToFile-TypeOfNodeData_TypeOfEdgeData--Save(Graph-SerializableConverter-SerializableGraph-TypeOfNodeData_TypeOfEdgeData-).md 'GraphSave.JsonSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Save(Graph.SerializableConverter.SerializableGraph&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
