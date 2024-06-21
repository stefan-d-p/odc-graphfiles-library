using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.GraphFiles.Structures;

[OSStructure(Description = "The publicationFacet resource provides details on the published status of a driveItemVersion or driveItem resource.")]
public struct PublicationFacet
{
    [OSStructureField(
        Description = "The state of publication for this document. Either published or checkout. Read-only.",
        DataType = OSDataType.Text)]
    public string Level;
    
    [OSStructureField(Description = "The unique identifier for the version that is visible to the current caller. Read-only.",
        DataType = OSDataType.Text)]
    public string VersionId;

    [OSStructureField(Description = "The user who checked out the file.",
        DataType = OSDataType.InferredFromDotNetType)]
    public IdentitySet CheckedOutBy;
}