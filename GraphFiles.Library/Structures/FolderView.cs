using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The FolderView resource provides or sets recommendations on the user-experience of a folder.")]
public struct FolderView
{
    [OSStructureField(Description = "The method by which the folder should be sorted.",
        DataType = OSDataType.Text)]
    public string SortBy;

    [OSStructureField(
        Description =
            "If true, indicates that items should be sorted in descending order. Otherwise, items should be sorted ascending.",
        DataType = OSDataType.Text)]
    public bool SortOrder;
    
    [OSStructureField(Description = "The type of view that should be used to represent the folder.",
        DataType = OSDataType.Text)]
    public string ViewType;
}