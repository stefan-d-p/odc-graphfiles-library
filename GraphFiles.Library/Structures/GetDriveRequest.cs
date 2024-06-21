using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "GetDrive Request Parameters")]
public struct GetDriveRequest
{
    [OSStructureField(Description = "Unique Identifier of drive",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string DriveId;
}