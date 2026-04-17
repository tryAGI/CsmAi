/*
order: 10
title: Image to 3D
slug: image-to-3d

Shows how to start an image-to-3D session using the legacy endpoint used by the
official Python SDK, then poll for its status.
*/

namespace CsmAi.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageTo3D()
    {
        using var client = GetAuthenticatedClient();

        //// Kick off an image-to-3D session from a public image URL.
        var envelope = await client.ImageTo3d.CreateImageTo3DSessionAsync(
            new LegacyImageTo3DRequest
            {
                ImageUrl = "https://via.placeholder.com/300/09f/fff.png",
                GeometryModel = GeometryModel.Turbo,
                TextureModel = TextureModel.Pbr,
            });
        envelope.Data.Should().NotBeNull();
        envelope.Data!.SessionCode.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Session Code: {envelope.Data.SessionCode}");

        //// Retrieve current status once.
        var status = await client.ImageTo3d.GetImageTo3DSessionAsync(envelope.Data.SessionCode!);
        status.Data.Should().NotBeNull();
        Console.WriteLine($"Status: {status.Data!.SessionStatus}, Progress: {status.Data.PercentDone}%");
    }
}
