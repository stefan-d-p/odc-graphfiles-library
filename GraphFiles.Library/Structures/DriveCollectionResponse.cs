using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Collection of Drive elements")]
public struct DriveCollectionResponse
{
    [OSStructureField(Description = "Drive Elements",
        DataType = OSDataType.InferredFromDotNetType)]
    public List<Structures.Drive> Value;
}