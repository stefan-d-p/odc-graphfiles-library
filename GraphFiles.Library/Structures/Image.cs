using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The image resource groups image-related properties into a single structure. If a driveItem has a non-null image facet, the item represents a bitmap image.")]
public struct Image
{
    [OSStructureField(Description = "Optional. Height of the image, in pixels. Read-only.",
        DataType = OSDataType.Integer)]
    public int Height;
    
    [OSStructureField(Description = "Optional. Width of the image, in pixels. Read-only.",
        DataType = OSDataType.Integer)]
    public int Width;
}