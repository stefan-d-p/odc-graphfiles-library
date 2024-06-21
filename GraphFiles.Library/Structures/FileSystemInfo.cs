using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The fileSystemInfo resource contains properties that are reported by the device's local file system for the local version of an item. This facet can be used to specify the last modified date or created date of the item as it was on the local device.")]
public struct FileSystemInfo
{
    [OSStructureField(Description = "The UTC date and time the file was created on a client.",
        DataType = OSDataType.DateTime)]
    public DateTime CreatedDateTime;

    [OSStructureField(
        Description = "The UTC date and time the file was last accessed. Available for the recent file list only.",
        DataType = OSDataType.DateTime)]
    public DateTime LastAccessedDateTime;
    
    [OSStructureField(Description = "The UTC date and time the file was last modified on a client.",
        DataType = OSDataType.DateTime)]
    public DateTime LastModifiedDateTime;

}