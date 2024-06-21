using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Access Credentials for Graph API access")]
public struct Credentials
{
    [OSStructureField(Description = "Access Token",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string AccessToken;
}