using System.Security.Cryptography;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructureField(Description = "A bundle is a logical grouping of files used to share multiple files at once. It is represented by a driveItem entity containing a bundle facet and can be shared in the same way as any other driveItem.")]
public struct Bundle
{
    [OSStructureField(Description = "If the bundle is an album, then the album property is included")]
    public Album Album;
    
    [OSStructureField(Description = "Number of children contained immediately within this container.",
        DataType = OSDataType.Integer)]
    public int ChildCount;
}