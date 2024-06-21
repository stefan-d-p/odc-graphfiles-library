using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The Folder resource groups folder-related data on an item into a single structure. DriveItems with a non-null folder facet are containers for other DriveItems.")]
public struct Folder
{
    [OSStructureField(Description = "Number of children contained immediately within this container.",
        DataType = OSDataType.Integer)]
    public int ChildCount;

    [OSStructureField(Description = "A collection of properties defining the recommended view for the folder.",
        DataType = OSDataType.InferredFromDotNetType)]
    public FolderView View;
}