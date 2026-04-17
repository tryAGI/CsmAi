/*
order: 30
title: Create a Scene session (v3)
slug: scene

Shows how to use the unified v3 Sessions API to create a full 3D scene generation
— CSM's headline capability distinguishing it from single-object generators.
*/

namespace CsmAi.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateScene()
    {
        using var client = GetAuthenticatedClient();

        //// Create a scene session using the unified v3 Sessions API.
        var session = await client.Sessions.CreateSessionAsync(
            new CreateSessionRequest
            {
                Type = SessionType.Scene,
                Input = new SessionInput
                {
                    Prompt = "a cozy medieval village at sunset with cobblestone streets",
                },
            });

        session.Should().NotBeNull();
        (session.Id ?? session.SessionCode).Should().NotBeNullOrEmpty();
        Console.WriteLine($"Scene session id: {session.Id ?? session.SessionCode}");
    }
}
