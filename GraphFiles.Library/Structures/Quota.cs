using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The quota resource provides details about space constraints on a drive resource. In OneDrive Personal, the values reflect the total/used unified storage quota across multiple Microsoft services.")]
public struct Quota
{
    [OSStructureField(Description = "Total space consumed by files in the recycle bin, in bytes. Read-only.",
        DataType = OSDataType.LongInteger)]
    public long Deleted;
    
    [OSStructureField(Description = "Total space remaining before reaching the quota limit, in bytes. Read-only.",
        DataType = OSDataType.LongInteger)]
    public long Remaining;
    
    [OSStructureField(Description = "Enumeration value that indicates the state of the storage space. Read-only.",
        DataType = OSDataType.Text)]
    public string State;
    
    [OSStructureField(Description = "Total allowed storage space, in bytes. Read-only.",
        DataType = OSDataType.LongInteger)]
    public long Total;
    
    [OSStructureField(Description = "Total space used, in bytes. Read-only.",
        DataType = OSDataType.LongInteger)]
    public long Used;
}