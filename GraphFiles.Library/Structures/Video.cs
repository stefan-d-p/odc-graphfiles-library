using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The video resource groups video-related data items into a single structure.")]
public struct Video
{
    [OSStructureField(Description = "Number of audio bits per sample.",
        DataType = OSDataType.Integer)]
    public int AudioBitsPerSample;
    
    [OSStructureField(Description = "Number of audio channels.",
        DataType = OSDataType.Integer)]
    public int AudioChannels;
    
    
}