using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Indicates that one or more operations that might affect the state of the driveItem are pending completion.")]
public struct PendingOperations
{
    [OSStructureField(
        Description =
            "A property that indicates that an operation that might update the binary content of a file is pending completion.",
        DataType = OSDataType.InferredFromDotNetType)]
    public PendingContentUpdate PendingContentUpdate;
}