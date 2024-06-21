using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The Deleted resource indicates that the item has been deleted. In this version of the API, the presence (non-null) of the resource value indicates that the file was deleted. A null (or missing) value indicates that the file is not deleted.")]
public struct Deleted
{
    [OSStructureField(Description = "Represents the state of the deleted item.",
        DataType = OSDataType.Text)]
    public string State;
}