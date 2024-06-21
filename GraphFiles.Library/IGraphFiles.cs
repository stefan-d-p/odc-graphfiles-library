using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles
{
    [OSInterface(
        Name = "MSGraphFiles",
        Description = "Interact with files store in OneDrive and Sharepoint Document Libraries via Microsoft Graph API",
        IconResourceName = "Without.Systems.GraphFiles.Resources.Microsoft.png")]
    public interface IGraphFiles
    {
        [OSAction(
            Description = "Retrieve the properties and relationships of a Drive resource",
            ReturnName = "result",
            ReturnType = OSDataType.InferredFromDotNetType,
            IconResourceName = "Without.Systems.GraphFiles.Resources.Microsoft.png")]
        Structures.Drive GetDrive(
            [OSParameter(
                Description = "Graph Access Token Credentials",
                DataType = OSDataType.InferredFromDotNetType)]
            Structures.Credentials credentials,
            [OSParameter(
                Description = "GetDrive Request Parameters",
                DataType = OSDataType.InferredFromDotNetType)]
            Structures.GetDriveRequest getDriveRequest);
    }
}