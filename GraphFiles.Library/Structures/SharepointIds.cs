using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The SharePointIds resource groups the various identifiers for an item stored in a SharePoint site or OneDrive for Business into a single structure.")]
public struct SharepointIds
{
    [OSStructureField(Description = "The unique identifier (guid) for the item's list in SharePoint.",
        DataType = OSDataType.Text)]
    public string ListId;

    [OSStructureField(Description = "An integer identifier for the item within the containing list.",
        DataType = OSDataType.Text)]
    public string ListItemId;

    [OSStructureField(
        Description = "The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.",
        DataType = OSDataType.Text)]
    public string ListItemUniqueId;
    
    [OSStructureField(Description = "The unique identifier (guid) for the item's site collection (SPSite).",
        DataType = OSDataType.Time)]
    public string SiteId;
    
    [OSStructureField(Description = "The SharePoint URL for the site that contains the item.",
        DataType = OSDataType.Text)]
    public string SiteUrl;
    
    [OSStructureField(Description = "The unique identifier (guid) for the tenancy.",
        DataType = OSDataType.Text)]
    public string TenantId;
    
    [OSStructureField(Description = "The unique identifier (guid) for the item's site (SPWeb).",
        DataType = OSDataType.Text)]
    public string WebId;
        

}