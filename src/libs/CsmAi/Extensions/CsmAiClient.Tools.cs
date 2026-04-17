using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace CsmAi;

/// <summary>
/// Extensions for using <see cref="CsmAiClient"/> as MEAI tools with any IChatClient.
/// </summary>
public static class CsmAiToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a 3D mesh from a text prompt
    /// by starting a text-to-image session (first stage of CSM's text-to-3D pipeline).
    /// Returns the created session code.
    /// </summary>
    /// <param name="client">The CSM AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsCreateTextTo3DTaskTool(this CsmAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Text prompt describing the 3D asset to generate")] string prompt,
                [Description("Optional style identifier influencing visual characteristics")] string? styleId,
                [Description("Guidance strength (higher = stricter adherence to prompt, default 6)")] int? guidance,
                CancellationToken cancellationToken) =>
            {
                var response = await client.TextToImage.CreateTextToImageSessionAsync(
                    new LegacyTextToImageRequest
                    {
                        Prompt = prompt,
                        StyleId = styleId ?? string.Empty,
                        Guidance = (guidance ?? 6).ToString(System.Globalization.CultureInfo.InvariantCulture),
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatLegacyTextToImageEnvelope(response);
            },
            name: "CreateTextTo3DTask",
            description: "Starts a text-to-3D generation on CSM AI by creating a text-to-image session (first pipeline stage). Returns the session_code to poll and then feed into image-to-3D.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a 3D mesh from a single image URL.
    /// Returns the created session code.
    /// </summary>
    /// <param name="client">The CSM AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsCreateImageTo3DTaskTool(this CsmAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Public URL or base64 data URI of the input image")] string imageUrl,
                [Description("Geometry model: base or turbo (default unset)")] string? geometryModel,
                [Description("Texture model: none, baked, or pbr (default unset)")] string? textureModel,
                CancellationToken cancellationToken) =>
            {
                var request = new LegacyImageTo3DRequest
                {
                    ImageUrl = imageUrl,
                };
                if (!string.IsNullOrWhiteSpace(geometryModel))
                {
                    request.GeometryModel = GeometryModelExtensions.ToEnum(geometryModel);
                }
                if (!string.IsNullOrWhiteSpace(textureModel))
                {
                    request.TextureModel = TextureModelExtensions.ToEnum(textureModel);
                }

                var response = await client.ImageTo3d.CreateImageTo3DSessionAsync(
                    request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatLegacyImageTo3DEnvelope(response);
            },
            name: "CreateImageTo3DTask",
            description: "Creates a CSM AI image-to-3D session to generate a textured 3D mesh from a single image URL. Returns a session_code to poll for status and GLB/FBX/OBJ/USDZ URLs when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that kicks off a full 3D scene generation
    /// (CSM's headline capability: world/scene output rather than a single object)
    /// via the unified v3 Sessions API. Returns the created session id.
    /// </summary>
    /// <param name="client">The CSM AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsCreateSceneTaskTool(this CsmAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Text prompt describing the 3D scene/world to generate")] string prompt,
                [Description("Optional reference image URL to guide scene style/composition")] string? imageUrl,
                [Description("Optional style identifier")] string? styleId,
                CancellationToken cancellationToken) =>
            {
                var request = new CreateSessionRequest
                {
                    Type = SessionType.Scene,
                    Input = new SessionInput
                    {
                        Prompt = prompt,
                        ImageUrl = string.IsNullOrWhiteSpace(imageUrl) ? null : imageUrl,
                        StyleId = string.IsNullOrWhiteSpace(styleId) ? null : styleId,
                    },
                };

                var session = await client.Sessions.CreateSessionAsync(
                    request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSession(session, "scene");
            },
            name: "CreateSceneTask",
            description: "Creates a CSM AI scene session — generates a full 3D scene/world from a text prompt (plus optional reference image). Returns a session id to poll for status and the final scene URL.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of a session via the unified v3 Sessions API. Accepts either a v3 session id
    /// or a legacy session_code.
    /// </summary>
    /// <param name="client">The CSM AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetTaskStatusTool(this CsmAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The v3 session id or legacy session_code to fetch")] string sessionId,
                CancellationToken cancellationToken) =>
            {
                var session = await client.Sessions.GetSessionAsync(
                    sessionId: sessionId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSession(session, "task");
            },
            name: "GetTaskStatus",
            description: "Fetches the status and outputs of any CSM AI session (image-to-3D, text-to-image, scene, kit, retopology) by id. Returns status, percent_done, and asset URLs (mesh_url_glb etc.) when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists the user's recent sessions
    /// via the unified v3 Sessions API (optionally filtered by type/status).
    /// </summary>
    /// <param name="client">The CSM AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListMyAssetsTool(this CsmAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Max number of sessions to return (default 10)")] int? limit,
                [Description("Page number for pagination (default 0)")] int? page,
                [Description("Optional session type filter: image_to_3d, multiview_to_3d, text_to_image, image_to_kit, retopology, scene")] string? type,
                CancellationToken cancellationToken) =>
            {
                SessionType? typeEnum = string.IsNullOrWhiteSpace(type)
                    ? null
                    : SessionTypeExtensions.ToEnum(type);

                var result = await client.Sessions.ListSessionsAsync(
                    limit: limit ?? 10,
                    page: page ?? 0,
                    type: typeEnum,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSessionList(result);
            },
            name: "ListMyAssets",
            description: "Lists the caller's CSM AI sessions (completed and in-progress 3D assets) via the unified v3 API, optionally filtered by type. Returns session ids, types, statuses, and primary asset URLs.");
    }

    private static string FormatLegacyImageTo3DEnvelope(LegacyImageTo3DSessionEnvelope envelope)
    {
        var parts = new List<string>();
        if (envelope.StatusCode is { } sc) parts.Add($"HTTP Status: {sc}");
        if (!string.IsNullOrWhiteSpace(envelope.Message)) parts.Add($"Message: {envelope.Message}");
        if (envelope.Data is { } data)
        {
            if (!string.IsNullOrWhiteSpace(data.SessionCode)) parts.Add($"Session Code: {data.SessionCode}");
            if (!string.IsNullOrWhiteSpace(data.Id)) parts.Add($"Session Id: {data.Id}");
            if (data.SessionStatus is { } status) parts.Add($"Status: {status.ToValueString()}");
            if (data.PercentDone is { } progress) parts.Add($"Progress: {progress}%");
            AppendMeshUrlsLegacy(data, parts);
        }
        return parts.Count > 0 ? string.Join("\n", parts) : "No session data returned.";
    }

    private static string FormatLegacyTextToImageEnvelope(LegacyTextToImageSessionEnvelope envelope)
    {
        var parts = new List<string>();
        if (envelope.StatusCode is { } sc) parts.Add($"HTTP Status: {sc}");
        if (!string.IsNullOrWhiteSpace(envelope.Message)) parts.Add($"Message: {envelope.Message}");
        if (envelope.Data is { } data)
        {
            if (!string.IsNullOrWhiteSpace(data.SessionCode)) parts.Add($"Session Code: {data.SessionCode}");
            if (!string.IsNullOrWhiteSpace(data.Id)) parts.Add($"Session Id: {data.Id}");
            if (data.Status is { } status) parts.Add($"Status: {status.ToValueString()}");
            if (!string.IsNullOrWhiteSpace(data.ImageUrl)) parts.Add($"Image URL: {data.ImageUrl}");
            if (!string.IsNullOrWhiteSpace(data.Prompt)) parts.Add($"Prompt: {data.Prompt}");
        }
        return parts.Count > 0 ? string.Join("\n", parts) : "No session data returned.";
    }

    private static string FormatSession(SessionResponse session, string label)
    {
        var parts = new List<string>();
        if (!string.IsNullOrWhiteSpace(session.Id)) parts.Add($"Session Id: {session.Id}");
        if (!string.IsNullOrWhiteSpace(session.SessionCode)) parts.Add($"Session Code: {session.SessionCode}");
        if (session.Type is { } type) parts.Add($"Type: {type.ToValueString()}");
        var status = session.Status ?? session.SessionStatus;
        if (status is { } s) parts.Add($"Status: {s.ToValueString()}");
        if (session.PercentDone is { } progress) parts.Add($"Progress: {progress}%");
        if (session.Output is { } output)
        {
            AppendSessionOutput(output, parts);
        }
        return parts.Count > 0
            ? string.Join("\n", parts)
            : $"No {label} data returned.";
    }

    private static string FormatSessionList(ListSessionsResponse response)
    {
        if (response.Results is not { Count: > 0 } results)
        {
            return "No sessions found.";
        }

        var parts = new List<string>();
        if (response.Total is { } total) parts.Add($"Total: {total}");
        parts.Add($"Returned: {results.Count}");
        for (var i = 0; i < results.Count; i++)
        {
            var s = results[i];
            var segments = new List<string>();
            if (!string.IsNullOrWhiteSpace(s.Id)) segments.Add($"id={s.Id}");
            else if (!string.IsNullOrWhiteSpace(s.SessionCode)) segments.Add($"code={s.SessionCode}");
            if (s.Type is { } t) segments.Add($"type={t.ToValueString()}");
            var status = s.Status ?? s.SessionStatus;
            if (status is { } st) segments.Add($"status={st.ToValueString()}");
            parts.Add($"  [{i}] {string.Join(", ", segments)}");
        }
        return string.Join("\n", parts);
    }

    private static void AppendMeshUrlsLegacy(LegacyImageTo3DSession data, List<string> parts)
    {
        var urls = new List<string>();
        if (!string.IsNullOrWhiteSpace(data.MeshUrlGlb)) urls.Add($"  GLB: {data.MeshUrlGlb}");
        if (!string.IsNullOrWhiteSpace(data.MeshUrlFbx)) urls.Add($"  FBX: {data.MeshUrlFbx}");
        if (!string.IsNullOrWhiteSpace(data.MeshUrlObj)) urls.Add($"  OBJ: {data.MeshUrlObj}");
        if (!string.IsNullOrWhiteSpace(data.MeshUrlUsdz)) urls.Add($"  USDZ: {data.MeshUrlUsdz}");
        if (!string.IsNullOrWhiteSpace(data.MeshUrlZip)) urls.Add($"  ZIP: {data.MeshUrlZip}");
        if (urls.Count > 0)
        {
            parts.Add("Mesh URLs:");
            parts.AddRange(urls);
        }
        if (!string.IsNullOrWhiteSpace(data.SpinVideoUrl)) parts.Add($"Spin Video: {data.SpinVideoUrl}");
    }

    private static void AppendSessionOutput(SessionOutput output, List<string> parts)
    {
        if (!string.IsNullOrWhiteSpace(output.ImageUrl)) parts.Add($"Image URL: {output.ImageUrl}");
        if (!string.IsNullOrWhiteSpace(output.SceneUrl)) parts.Add($"Scene URL: {output.SceneUrl}");

        var urls = new List<string>();
        if (!string.IsNullOrWhiteSpace(output.MeshUrlGlb)) urls.Add($"  GLB: {output.MeshUrlGlb}");
        if (!string.IsNullOrWhiteSpace(output.MeshUrlFbx)) urls.Add($"  FBX: {output.MeshUrlFbx}");
        if (!string.IsNullOrWhiteSpace(output.MeshUrlObj)) urls.Add($"  OBJ: {output.MeshUrlObj}");
        if (!string.IsNullOrWhiteSpace(output.MeshUrlUsdz)) urls.Add($"  USDZ: {output.MeshUrlUsdz}");
        if (!string.IsNullOrWhiteSpace(output.MeshUrlZip)) urls.Add($"  ZIP: {output.MeshUrlZip}");
        if (!string.IsNullOrWhiteSpace(output.MeshUrl)) urls.Add($"  Generic: {output.MeshUrl}");
        if (urls.Count > 0)
        {
            parts.Add("Mesh URLs:");
            parts.AddRange(urls);
        }

        if (!string.IsNullOrWhiteSpace(output.PreviewMeshUrlGlb)) parts.Add($"Preview GLB: {output.PreviewMeshUrlGlb}");
        if (!string.IsNullOrWhiteSpace(output.SpinVideoUrl)) parts.Add($"Spin Video: {output.SpinVideoUrl}");

        if (output.Parts is { Count: > 0 } kitParts)
        {
            parts.Add($"Kit parts: {kitParts.Count}");
            for (var i = 0; i < kitParts.Count; i++)
            {
                var p = kitParts[i];
                var segments = new List<string>();
                if (!string.IsNullOrWhiteSpace(p.Id)) segments.Add($"id={p.Id}");
                if (!string.IsNullOrWhiteSpace(p.Name)) segments.Add($"name={p.Name}");
                if (!string.IsNullOrWhiteSpace(p.MeshUrlGlb)) segments.Add($"glb={p.MeshUrlGlb}");
                parts.Add($"  [{i}] {string.Join(", ", segments)}");
            }
        }
    }
}
