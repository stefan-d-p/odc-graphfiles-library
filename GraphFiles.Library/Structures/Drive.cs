using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The top-level object that represents a user's OneDrive or a document library in SharePoint.")]
public struct Drive
{
    [OSStructureField(Description = "Identity of the user, device, or application which created the item. Read-only.")]
    public IdentitySet CreatedBy;
    
    [OSStructureField(Description = "Date and time of item creation. Read-only.")]
    public DateTime CreatedDateTime;
    
    [OSStructureField(Description = "Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.")]
    public string DriveType;
    
    [OSStructureField(Description = "The unique identifier of the drive. Read-only.")]
    public string Id;
    
    [OSStructureField(Description = "Identity of the user, device, and application which last modified the item. Read-only.")]
    public IdentitySet LastModifiedBy;
    
    [OSStructureField(Description = "Date and time the item was last modified. Read-only.")]
    public DateTime LastModifiedDateTime;
    
    [OSStructureField(Description = "The name of the item. Read-write.")]
    public string Name;

    [OSStructureField(Description = "Optional. The user account that owns the drive. Read-only.")]
    public IdentitySet Owner;
    
    [OSStructureField(Description = "Optional. Information about the drive's storage space quota. Read-only.")]
    public Quota Quota;

    [OSStructureField(Description =
        "Returns identifiers useful for SharePoint REST compatibility. Read-only. This property is not returned by default and must be selected using the $select query parameter.")]
    public SharepointIds SharepointIds;
    
    [OSStructureField(Description = "URL that displays the resource in the browser. Read-only.")]
    public string WebUrl;


}