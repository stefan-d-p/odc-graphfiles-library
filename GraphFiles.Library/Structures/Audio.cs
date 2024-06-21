using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The Audio resource groups audio-related properties on an item into a single structure.")]
public struct Audio
{
    [OSStructureField(Description = "The title of the album for this audio file",
        DataType = OSDataType.Text)]
    public string Album;

    [OSStructureField(Description = "The artist named on the album for the audio file.",
        DataType = OSDataType.Text)]
    public string AlbumArtist;

    [OSStructureField(Description = "The performing artist for the audio file.",
        DataType = OSDataType.Text)]
    public string Artist;

    [OSStructureField(Description = "Bitrate expressed in kbps.",
        DataType = OSDataType.LongInteger)]
    public long Bitrate;

    [OSStructureField(Description = "The name of the composer of the audio file.",
        DataType = OSDataType.Text)]
    public string Composers;

    [OSStructureField(Description = "Copyright information for the audio file.",
        DataType = OSDataType.Text)]
    public string Copyright;

    [OSStructureField(Description = "The number of the disc this audio file came from.",
        DataType = OSDataType.Integer)]
    public int Disc;

    [OSStructureField(Description = "The total number of discs in this album.",
        DataType = OSDataType.Integer)]
    public int DiscCount;

    [OSStructureField(Description = "Duration of the audio file, expressed in milliseconds",
        DataType = OSDataType.LongInteger)]
    public long Duration;

    [OSStructureField(Description = "The genre of this audio file.",
        DataType = OSDataType.Text)]
    public string Genre;

    [OSStructureField(Description = "Indicates if the file is protected with digital rights management.",
        DataType = OSDataType.Boolean)]
    public bool HasDrm;

    [OSStructureField(Description = "Indicates if the file is encoded with a variable bitrate.",
        DataType = OSDataType.Boolean)]
    public bool IsVariableBitrate;

    [OSStructureField(Description = "The title of the audio file.",
        DataType = OSDataType.Text)]
    public string Title;
    
    [OSStructureField(Description = "The number of the track on the original disc for this audio file.",
        DataType = OSDataType.Integer)]
    public int Track;
    
    [OSStructureField(Description = "The total number of tracks on the original disc for this audio file.",
        DataType = OSDataType.Integer)]
    public int TrackCount;
    
    [OSStructureField(Description = "The year the audio file was recorded.",
        DataType = OSDataType.Integer)]
    public int Year;

}