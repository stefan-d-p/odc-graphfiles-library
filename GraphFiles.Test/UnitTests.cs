using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using Without.Systems.GraphFiles.Structures;
using Drive = Without.Systems.GraphFiles.Structures.Drive;

namespace Without.Systems.GraphFiles.Test;

public class Tests
{
    private static readonly IGraphFiles _actions = new GraphFiles();
    private static readonly HttpClient _httpClient = new HttpClient();

    private ClientCredentialsTokenRequest _tokenRequest;

    [SetUp]
    public void Setup()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddUserSecrets<Tests>()
            .AddEnvironmentVariables()
            .Build();

        string tenantId = configuration["TenantId"] ?? throw new InvalidOperationException();
        string clientId = configuration["ClientId"] ?? throw new InvalidOperationException();
        string clientSecret = configuration["ClientSecret"] ?? throw new InvalidOperationException();

        _tokenRequest = new ClientCredentialsTokenRequest
        {
            Address = $"https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token",
            Scope = "https://graph.microsoft.com/.default",
            ClientId = clientId,
            ClientSecret = clientSecret
        };
    }

    [Test]
    public void GetDrive_Test()
    {
        string driveId = "b!Nw2TqbvAJkijrFLKZmp2cEEREYRE51tOpzBg2qalI_zel1hKx-A7Ram4_h1YNApq";
        
        string accessToken = GetAccessToken();
        Credentials credentials = new Credentials { AccessToken = accessToken };
        GetDriveRequest request = new GetDriveRequest { DriveId = driveId };
        
        Drive drive = _actions.GetDrive(credentials, request);
    }

    private string GetAccessToken()
    {
        return _httpClient.RequestClientCredentialsTokenAsync(_tokenRequest).Result.AccessToken ?? string.Empty;
    }
}