/*
order: 50
title: MEAI Tools
slug: meai-tools

Shows how to use CSM AI AIFunction tools with any IChatClient.
*/

namespace CsmAi.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsCreateTextTo3DTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text-to-3D tool that can be passed to any IChatClient.
        var tool = client.AsCreateTextTo3DTaskTool();
        tool.Name.Should().Be("CreateTextTo3DTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsCreateImageTo3DTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image-to-3D tool for generating 3D meshes from images.
        var tool = client.AsCreateImageTo3DTaskTool();
        tool.Name.Should().Be("CreateImageTo3DTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsCreateSceneTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a scene generation tool — CSM's headline full-scene capability.
        var tool = client.AsCreateSceneTaskTool();
        tool.Name.Should().Be("CreateSceneTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetTaskStatusTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a status-check tool for any session id.
        var tool = client.AsGetTaskStatusTool();
        tool.Name.Should().Be("GetTaskStatus");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListMyAssetsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists the user's recent sessions/assets.
        var tool = client.AsListMyAssetsTool();
        tool.Name.Should().Be("ListMyAssets");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all tools for full CSM AI capabilities in a single IChatClient.
        var tools = new[]
        {
            client.AsCreateTextTo3DTaskTool(),
            client.AsCreateImageTo3DTaskTool(),
            client.AsCreateSceneTaskTool(),
            client.AsGetTaskStatusTool(),
            client.AsListMyAssetsTool(),
        };

        tools.Should().HaveCount(5);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
