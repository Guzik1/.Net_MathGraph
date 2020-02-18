#### [GraphSave](./index.md 'index')
### [GraphSave](./GraphSave.md 'GraphSave')
## XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt; Class
This class is using to load and save, serializable graph, to xml text file. Implement ISavable interface.  
```csharp
public class XmlSaveToFile<TypeOfNodeData,TypeOfEdgeData> : DiscGraphSave,
ISavable<TypeOfNodeData, TypeOfEdgeData>
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &gt; [DiscGraphSave](./GraphSave-DiscGraphSave.md 'GraphSave.DiscGraphSave') &gt; [XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;](./GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  

Implements [GraphSave.ISavable&lt;](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfNodeData](#GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData 'GraphSave.XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfNodeData')[,](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')[TypeOfEdgeData](#GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData 'GraphSave.XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.TypeOfEdgeData')[&gt;](./GraphSave-ISavable-TypeOfNodeData_TypeOfEdgeData-.md 'GraphSave.ISavable&lt;TypeOfNodeData,TypeOfEdgeData&gt;')  
#### Type parameters
<a name='GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfNodeData'></a>
`TypeOfNodeData`  
Type of node data.  
  
<a name='GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--TypeOfEdgeData'></a>
`TypeOfEdgeData`  
Type of edge data.  
  
### Constructors
- [XmlSaveToFile(string)](./GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--XmlSaveToFile(string).md 'GraphSave.XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.XmlSaveToFile(string)')
### Methods
- [Load()](./GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--Load().md 'GraphSave.XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Load()')
- [Save(Graph.SerializableConverter.SerializableGraph&lt;TypeOfNodeData,TypeOfEdgeData&gt;)](./GraphSave-XmlSaveToFile-TypeOfNodeData_TypeOfEdgeData--Save(Graph-SerializableConverter-SerializableGraph-TypeOfNodeData_TypeOfEdgeData-).md 'GraphSave.XmlSaveToFile&lt;TypeOfNodeData,TypeOfEdgeData&gt;.Save(Graph.SerializableConverter.SerializableGraph&lt;TypeOfNodeData,TypeOfEdgeData&gt;)')
