using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The package resource indicates that a driveItem is the top-level item in a \"package\" or a collection of items that should be treated as a collection instead of individual items.")]
public struct Package
{
    [OSStructureField(Description = "A string indicating the type of package. While oneNote is the only currently defined value, you should expect other package types to be returned and handle them accordingly.",
        DataType = OSDataType.Text)]
    public string Type;
}