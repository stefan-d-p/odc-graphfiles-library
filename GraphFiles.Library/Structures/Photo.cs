using Microsoft.Graph.Models;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The photo resource provides photo and camera properties, for example, EXIF metadata, on a driveItem.")]
public struct Photo
{
    [OSStructureField(Description = "Camera manufacturer. Read-only.",
        DataType = OSDataType.Text)]
    public string CameraMake;
    
    [OSStructureField(Description = "Camera model. Read-only.",
        DataType = OSDataType.Text)]
    public string CameraModel;

    [OSStructureField(Description = "The denominator for the exposure time fraction from the camera. Read-only.",
        DataType = OSDataType.Decimal)]
    public double ExposureDenominator;
    
    [OSStructureField(Description = "The numerator for the exposure time fraction from the camera. Read-only.",
        DataType = OSDataType.Decimal)]
    public double ExposureNumerator;

    [OSStructureField(Description = "The F-stop value from the camera. Read-only.",
        DataType = OSDataType.Decimal)]
    public double FNumber;
    
    [OSStructureField(Description = "The focal length from the camera. Read-only.",
        DataType = OSDataType.Decimal)]
    public double FocalLength;

    [OSStructureField(Description = "The ISO value from the camera. Read-only.",
        DataType = OSDataType.Integer)]
    public int Iso;
    
    [OSStructureField(Description = "The orientation value from the camera. Writable on OneDrive Personal.",
        DataType = OSDataType.Integer)]
    public int Orientation;
    
    [OSStructureField(Description = "Represents the date and time the photo was taken. Read-only.",
        DataType = OSDataType.DateTime)]
    public DateTime TakenDateTime;

}