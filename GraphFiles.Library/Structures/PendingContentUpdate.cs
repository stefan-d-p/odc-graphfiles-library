using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Indicates that an operation that might affect the binary content of the driveItem is pending completion.")]
public struct PendingContentUpdate
{
    [OSStructureField(Description = "Date and time the pending binary operation was queued in UTC time. Read-only.",
        DataType = OSDataType.DateTime)]
    public DateTime QueuedDateTime;
    
}