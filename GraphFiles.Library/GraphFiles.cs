using System.Net.Http.Headers;
using AutoMapper;
using Microsoft.Graph;
using Without.Systems.GraphFiles.Util;

namespace Without.Systems.GraphFiles;

public class GraphFiles : IGraphFiles
{

    private readonly IMapper _mapper;
    
    private static readonly HttpClient HttpClient = new();

    private static readonly DateTime DefaultDatetime = new DateTime(1900, 1, 1);

    public GraphFiles()
    {
        MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Microsoft.Graph.Models.Identity, Structures.Identity>();
            cfg.CreateMap<Microsoft.Graph.Models.IdentitySet, Structures.IdentitySet>();
            cfg.CreateMap<Microsoft.Graph.Models.SharepointIds, Structures.SharepointIds>();
            cfg.CreateMap<Microsoft.Graph.Models.Quota, Structures.Quota>();
            cfg.CreateMap<Microsoft.Graph.Models.Drive, Structures.Drive>()
                .ForMember(dest => dest.CreatedDateTime, opt => opt.MapFrom(src => src.CreatedDateTime.HasValue ? src.CreatedDateTime.Value.UtcDateTime : DefaultDatetime))
                .ForMember(dest => dest.LastModifiedDateTime, opt => opt.MapFrom(src => src.LastModifiedDateTime.HasValue ? src.LastModifiedDateTime.Value.UtcDateTime : DefaultDatetime));

            cfg.CreateMap<Microsoft.Graph.Models.DriveCollectionResponse, Structures.DriveCollectionResponse>();

            cfg.CreateMap<Microsoft.Graph.Models.Audio, Structures.Audio>();
            cfg.CreateMap<Microsoft.Graph.Models.Album, Structures.Album>();
            cfg.CreateMap<Microsoft.Graph.Models.Bundle, Structures.Bundle>();
            cfg.CreateMap<Microsoft.Graph.Models.Deleted, Structures.Deleted>();
            cfg.CreateMap<Microsoft.Graph.Models.Hashes, Structures.Hashes>();
            cfg.CreateMap<Microsoft.Graph.Models.FileObject, Structures.FileObject>();
            cfg.CreateMap<Microsoft.Graph.Models.FileSystemInfo, Structures.FileSystemInfo>()
                .ForMember(dest => dest.CreatedDateTime, opt => opt.MapFrom(src => src.CreatedDateTime.HasValue ? src.CreatedDateTime.Value.UtcDateTime : DefaultDatetime))
                .ForMember(dest => dest.LastAccessedDateTime, opt => opt.MapFrom(src => src.LastAccessedDateTime.HasValue ? src.LastAccessedDateTime.Value.UtcDateTime : DefaultDatetime))
                .ForMember(dest => dest.LastModifiedDateTime, opt => opt.MapFrom(src => src.LastModifiedDateTime.HasValue ? src.LastModifiedDateTime.Value.UtcDateTime : DefaultDatetime));
            
            cfg.CreateMap<Microsoft.Graph.Models.FolderView, Structures.FolderView>();
            cfg.CreateMap<Microsoft.Graph.Models.Folder, Structures.Folder>();
            cfg.CreateMap<Microsoft.Graph.Models.Image, Structures.Image>();
            cfg.CreateMap<Microsoft.Graph.Models.GeoCoordinates, Structures.GeoCoordinates>();
            cfg.CreateMap<Microsoft.Graph.Models.Malware, Structures.Malware>();
            cfg.CreateMap<Microsoft.Graph.Models.Package, Structures.Package>();
            cfg.CreateMap<Microsoft.Graph.Models.ItemReference, Structures.ItemReference>();
            cfg.CreateMap<Microsoft.Graph.Models.PendingContentUpdate, Structures.PendingContentUpdate>()
                .ForMember(dest => dest.QueuedDateTime,
                    opt => opt.MapFrom(src =>
                        src.QueuedDateTime.HasValue ? src.QueuedDateTime.Value.UtcDateTime : DefaultDatetime));
            cfg.CreateMap<Microsoft.Graph.Models.PendingOperations, Structures.PendingOperations>();
            cfg.CreateMap<Microsoft.Graph.Models.Photo, Structures.Photo>()
                .ForMember(dest => dest.TakenDateTime,
                    opt => opt.MapFrom(src =>
                        src.TakenDateTime.HasValue ? src.TakenDateTime.Value.UtcDateTime : DefaultDatetime));
            cfg.CreateMap<Microsoft.Graph.Models.PublicationFacet, Structures.PublicationFacet>();
            cfg.CreateMap<Microsoft.Graph.Models.Shared, Structures.Shared>()
                .ForMember(dest => dest.SharedDateTime,
                    opt => opt.MapFrom(src =>
                        src.SharedDateTime.HasValue ? src.SharedDateTime.Value.UtcDateTime : DefaultDatetime));
            cfg.CreateMap<Microsoft.Graph.Models.SpecialFolder, Structures.SpecialFolder>();
            cfg.CreateMap<Microsoft.Graph.Models.Video, Structures.Video>();
            cfg.CreateMap<Microsoft.Graph.Models.DriveItem, Structures.DriveItem>()
                .ForMember(dest => dest.CreatedDateTime,
                    opt => opt.MapFrom(src =>
                        src.CreatedDateTime.HasValue 
                            ? src.CreatedDateTime.Value.UtcDateTime 
                            : DefaultDatetime))
                .ForMember(dest => dest.LastModifiedDateTime,
                    opt => opt.MapFrom(src =>
                        src.LastModifiedDateTime.HasValue
                            ? src.LastModifiedDateTime.Value.UtcDateTime
                            : DefaultDatetime));
            
        });
        
        _mapper = mapperConfiguration.CreateMapper();
    }

    /// <summary>
    /// Retrieve details for a specific OneDrive or Sharepoint Document Library
    /// </summary>
    /// <param name="credentials">Access Token credentials</param>
    /// <param name="getDriveRequest">GetDrive Request Parameters</param>
    /// <returns>Drive result</returns>
    /// <exception cref="KeyNotFoundException"></exception>
    public Structures.Drive GetDrive(Structures.Credentials credentials, Structures.GetDriveRequest getDriveRequest)
    {
        GraphServiceClient graphClient = GetGraphServiceClient(credentials.AccessToken);
        Microsoft.Graph.Models.Drive result =
            AsyncUtil.RunSync(() => graphClient.Drives[getDriveRequest.DriveId].GetAsync()) ??
            throw new KeyNotFoundException();
        return _mapper.Map<Structures.Drive>(result);
    }
    
    /// <summary>
    /// Get a collection of available drives for the current credentials
    /// </summary>
    /// <param name="credentials">Access Token credentials</param>
    /// <returns>Collection of Drive Elements</returns>
    /// <exception cref="KeyNotFoundException"></exception>
    public Structures.DriveCollectionResponse GetDrives(Structures.Credentials credentials)
    {
        GraphServiceClient graphClient = GetGraphServiceClient(credentials.AccessToken);
        Microsoft.Graph.Models.DriveCollectionResponse result =
            AsyncUtil.RunSync(() => graphClient.Drives.GetAsync()) ??
            throw new KeyNotFoundException();
        return _mapper.Map<Structures.DriveCollectionResponse>(result);
    }
    
    private GraphServiceClient GetGraphServiceClient(string accessToken)
    {
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        return new GraphServiceClient(HttpClient);
    }
}