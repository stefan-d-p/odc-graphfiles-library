using System.ComponentModel.DataAnnotations;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "A photo album is a way to virtually group driveItems with photo facets together in a bundle. Bundles of this type have the album property set on the bundle resource")]
public struct Album
{
    [OSStructureField(Description = "Unique identifier of the driveItem that is the cover of the album.",
        DataType = OSDataType.Text)]
    public string CoverImageItemId;
}