using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The driveItem resource represents a file, folder, or other item stored in a drive.")]
public struct DriveItem
{
    [OSStructureField(Description =
        "Audio metadata, if the item is an audio file. Read-only. Read-only. Only on OneDrive Personal.")]
    public Audio Audio;
    
    [OSStructureField(Description = "Bundle metadata, if the item is a bundle. Read-only.")]
    public Bundle Bundle;
    
    [OSStructureField(Description = "Content data if the item represents a file",
        DataType = OSDataType.BinaryData)]
    public byte[] Content;
    
    [OSStructureField(Description = "Identity of the user, device, and application that created the item. Read-only.")]
    public IdentitySet CreatedBy;
    
    [OSStructureField(Description = "Date and time of item creation. Read-only.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDateTime;

    [OSStructureField(
        Description =
            "An eTag for the content of the item. This eTag isn't changed if only the metadata is changed. Note This property isn't returned if the item is a folder. Read-only.",
        DataType = OSDataType.Text)]
    public string CTag;
    
    [OSStructureField(Description = "Information about the deleted state of the item. Read-only.")]
    public Deleted Deleted;
    
    [OSStructureField(Description = "Provides a user-visible description of the item. Read-write. Only on OneDrive Personal.",
        DataType = OSDataType.Text)]
    public string Description;
    
    [OSStructureField(Description = "eTag for the entire item (metadata + content). Read-only.",
        DataType = OSDataType.Text)]
    public string ETag;
    
    [OSStructureField(Description = "File metadata, if the item is a file. Read-only.")]
    public FileObject File;
    
    [OSStructureField(Description = "File system information on client. Read-write.")]
    public FileSystemInfo FileSystemInfo;
    
    [OSStructureField(Description = "Folder metadata, if the item is a folder. Read-only.")]
    public Folder Folder;
    
    [OSStructureField(Description = "The unique identifier of the item within the Drive. Read-only.",
        DataType = OSDataType.Text)]
    public string Id;
    
    [OSStructureField(Description = "Image metadata, if the item is an image. Read-only.")]
    public Image Image;
    
    [OSStructureField(Description = "Identity of the user, device, and application that last modified the item. Read-only.")]
    public IdentitySet LastModifiedBy;
    
    [OSStructureField(Description = "Date and time the item was last modified. Read-only.",
        DataType = OSDataType.DateTime)]
    public DateTime LastModifiedDateTime;

    [OSStructureField(Description = "Location metadata, if the item has location data. Read-only.")]
    public GeoCoordinates Location;
    
    [OSStructureField(Description = "Malware metadata, if the item was detected to contain malware. Read-only.")]
    public Malware Malware;
    
    [OSStructureField(Description = "The name of the item (filename and extension). Read-write.",
        DataType = OSDataType.Text)]
    public string Name;
    
    [OSStructureField(Description = "If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.")]
    public Package Package;
    
    [OSStructureField(Description = "Parent information, if the item has a parent. Read-write.")]
    public ItemReference ParentReference;
    
    [OSStructureField(Description = "If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.")]
    public PendingOperations PendingOperations;
    
    [OSStructureField(Description = "Photo metadata, if the item is a photo. Read-only.")]
    public Photo Photo;

    [OSStructureField(Description =
        "Indicates that the item was shared with others and provides information about the shared state of the item. Read-only.")]
    public Shared Shared;

    [OSStructureField(Description = "Returns identifiers useful for SharePoint REST compatibility. Read-only.")]
    public SharepointIds SharepointIds;
    
    [OSStructureField(Description = "Size of the item in bytes. Read-only.",
        DataType = OSDataType.LongInteger)]
    public long Size;
    
    [OSStructureField(Description = "If the current item is also available as a special folder, this facet is returned. Read-only.")]
    public SpecialFolder SpecialFolder;
    
    [OSStructureField(Description = "Video metadata, if the item is a video. Read-only.")]
    public Video Video;
    
    [OSStructureField(Description = "WebDAV compatible URL for the item.",
        DataType = OSDataType.Text)]
    public string WebDavUrl;

    [OSStructureField(Description = "URL that displays the resource in the browser. Read-only.",
        DataType = OSDataType.Text)]
    public string WebUrl;

}