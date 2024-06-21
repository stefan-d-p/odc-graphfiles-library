using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The SpecialFolder resource groups special folder-related data items into a single structure.")]
public struct SpecialFolder
{
    [OSStructureField(Description = "The unique identifier for this item in the /drive/special collection",
        DataType = OSDataType.Text)]
    public string Name;
}