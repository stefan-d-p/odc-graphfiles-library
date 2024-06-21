using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The File resource groups file-related data items into a single structure.")]
public struct FileObject
{
    [OSStructureField(Description = "Hashes of the file's binary content, if available. Read-only.")]
    public Hashes Hashes;
    
    [OSStructureField(Description = "The MIME type for the file. This is determined by logic on the server and might not be the value provided when the file was uploaded. Read-only.",
        DataType = OSDataType.Text)]
    public string MimeType;
}