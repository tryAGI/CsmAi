/*
order: 20
title: Text to 3D (text-to-image stage)
slug: text-to-3d

Shows how to start a text-to-image session — the first stage of CSM's text-to-3D
pipeline. The returned image is then piped into an image-to-3D session.
*/

namespace CsmAi.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextTo3D()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text-to-image session (first stage of the text-to-3D pipeline).
        var response = await client.TextToImage.CreateTextToImageSessionAsync(
            new LegacyTextToImageRequest
            {
                Prompt = "a wooden treasure chest, front view, clean background",
                StyleId = string.Empty,
                Guidance = "6",
            });
        response.Data.Should().NotBeNull();
        response.Data!.SessionCode.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Session Code: {response.Data.SessionCode}");

        //// Fetch the session once.
        var status = await client.TextToImage.GetTextToImageSessionAsync(response.Data.SessionCode!);
        status.Data.Should().NotBeNull();
        Console.WriteLine($"Status: {status.Data!.Status}");
    }
}
