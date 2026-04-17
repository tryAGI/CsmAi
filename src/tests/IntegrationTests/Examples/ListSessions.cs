/*
order: 40
title: List sessions
slug: list-sessions

Shows how to list recent sessions (user's 3D assets) via the unified v3 API.
*/

namespace CsmAi.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListSessions()
    {
        using var client = GetAuthenticatedClient();

        //// List up to 5 recent sessions for the current user.
        var result = await client.Sessions.ListSessionsAsync(limit: 5);
        result.Should().NotBeNull();
        Console.WriteLine($"Returned {result.Results?.Count ?? 0} sessions (total={result.Total}).");
    }
}
