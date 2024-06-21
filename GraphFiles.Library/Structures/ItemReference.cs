using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The itemReference resource provides information necessary to address a driveItem or a listItem via the API.")]
public struct ItemReference
{
    [OSStructureField(
        Description =
            "Unique identifier of the drive instance that contains the driveItem. Only returned if the item is located in a drive. Read-only.",
        DataType = OSDataType.Text)]
    public string DriveId;
    
    [OSStructureField(Description = "Identifies the type of drive. Only returned if the item is located in a drive. See drive resource for values.",
        DataType = OSDataType.Text)]
    public string DriveType;
    
    [OSStructureField(Description = "Unique identifier of the driveItem in the drive or a listItem in a list. Read-only.",
        DataType = OSDataType.Text)]
    public string Id;
    
    [OSStructureField(Description = "The name of the item being referenced. Read-only.",
        DataType = OSDataType.Text)]
    public string Name;
    
    [OSStructureField(Description = "Percent-encoded path that can be used to navigate to the item. Read-only.",
        DataType = OSDataType.Text)]
    public string Path;
    
    [OSStructureField(Description = "A unique identifier for a shared resource that can be accessed via the Shares API.",
        DataType = OSDataType.Text)]
    public string ShareId;
    
    [OSStructureField(Description = "Returns identifiers useful for SharePoint REST compatibility. Read-only.",
        DataType = OSDataType.InferredFromDotNetType)]
    public SharepointIds SharepointIds;
    
    [OSStructureField(Description = "For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource or the parent list of the listItem resource. The value is the same as the id property of that site resource. It is an opaque string that consists of three identifiers of the site.",
        DataType = OSDataType.Text)]
    public string SiteId;
}