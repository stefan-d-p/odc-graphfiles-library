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
    
    [OSStructureField(Description = "Name of the audio format (AAC, MP3, etc.).",
        DataType = OSDataType.Text)]
    public string AudioFormat;
    
    [OSStructureField(Description = "Number of audio samples per second.",
        DataType = OSDataType.Integer)]
    public int AudioSamplesPerSecond;
    
    [OSStructureField(Description = "Bit rate of the video in bits per second.",
        DataType = OSDataType.Integer)]
    public int BitRate;
    
    [OSStructureField(Description = "Duration of the file in milliseconds.",
        DataType = OSDataType.LongInteger)]
    public long Duration;

    [OSStructureField(Description = "\"Four character code\" name of the video format.",
        DataType = OSDataType.Text)]
    public string FourCC;
    
    [OSStructureField(Description = "Frame rate of the video.",
        DataType = OSDataType.Decimal)]
    public double FrameRate;
    
    [OSStructureField(Description = "Height of the video, in pixels.",
        DataType = OSDataType.Integer)]
    public int Height;
    
    [OSStructureField(Description = "Width of the video, in pixels.",
        DataType = OSDataType.Integer)]
    public int Width;
    
}