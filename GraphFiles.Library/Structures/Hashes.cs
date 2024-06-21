using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The hashes resource groups available hashes into a single structure for an item.")]
public struct Hashes
{
    [OSStructureField(Description = "The CRC32 value of the file in little endian (if available). Read-only.",
        DataType = OSDataType.Text)]
    public string Crc32Hash;

    [OSStructureField(
        Description =
            "A proprietary hash of the file that can be used to determine if the contents of the file have changed (if available). Read-only.",
        DataType = OSDataType.Text)]
    public string QuickXorHash;
    
    [OSStructureField(Description = "SHA1 hash for the contents of the file (if available). Read-only.",
        DataType = OSDataType.Text)]
    public string Sha1Hash;
    
    [OSStructureField(Description = "SHA256 hash for the contents of the file (if available). Read-only.",
        DataType = OSDataType.Text)]
    public string Sha256Hash;
    
}