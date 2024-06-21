using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The GeoCoordinates resource provides geographic coordinates and elevation of a location based on metadata contained within the file. If a DriveItem has a non-null location facet, the item represents a file with a known location assocaited with it.")]
public struct GeoCoordinates
{
    [OSStructureField(Description = "Optional. The altitude (height), in feet, above sea level for the item. Read-only.",
        DataType = OSDataType.Decimal)]
    public double Altitude;
    
    [OSStructureField(Description = "Optional. The latitude, in degrees, for the item. Read-only.",
        DataType = OSDataType.Decimal)]
    public double Latitude;
    
    [OSStructureField(Description = "Optional. The longitude, in degrees, for the item. Read-only.",
        DataType = OSDataType.Decimal)]
    public double Longitude;
}