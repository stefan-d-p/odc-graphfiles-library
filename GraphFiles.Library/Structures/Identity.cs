using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "Represents an identity of an actor. For example, an actor can be a user, device, or application.")]
public struct Identity
{
    [OSStructureField(Description = "The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user don't show up as having changed when using delta.",
        DataType = OSDataType.Text)]
    public string DisplayName;
    
    [OSStructureField(Description = "Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.",
        DataType = OSDataType.Text)]
    public string Id;
    
    [OSStructureField(Description = "Unique identity of the tenant. Optional.",
        DataType = OSDataType.Text)]
    public string TenantId;
}