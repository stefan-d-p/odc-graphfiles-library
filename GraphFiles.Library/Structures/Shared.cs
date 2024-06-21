using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Indicates that a drive item was shared with others and includes information about how the item was shared.")]
public struct Shared
{
    [OSStructureField(Description = "The identity of the owner of the shared item. Read-only.",
        DataType = OSDataType.InferredFromDotNetType)]
    public IdentitySet Owner;

    [OSStructureField(Description = "The identity of the user who shared the item. Read-only.",
        DataType = OSDataType.InferredFromDotNetType)]
    public IdentitySet SharedBy;
    
    [OSStructureField(Description = "The UTC date and time when the item was shared. Read-only.",
        DataType = OSDataType.DateTime)]
    public DateTime SharedDateTime;

    [OSStructureField(
        Description =
            "Indicates the scope of how the item is shared. The possible values are: anonymous, organization, or users. Read-only.",
        DataType = OSDataType.Text)]
    public string Scope;
}