namespace CsmAi.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CsmAiClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("CSM_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("CSMAI_API_KEY") is { Length: > 0 } altKeyValue ? altKeyValue :
            throw new AssertInconclusiveException("CSM_API_KEY environment variable is not found.");

        var client = new CsmAiClient(apiKey);
        
        return client;
    }
}
