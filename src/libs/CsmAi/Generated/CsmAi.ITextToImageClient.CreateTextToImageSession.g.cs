#nullable enable

namespace CsmAi
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// (Legacy) Create a text-to-image session<br/>
        /// Legacy endpoint used by the official Python client for text-to-3D generation<br/>
        /// (pipeline is text → image → image-to-3D). Prefer `POST /v3/sessions/` with<br/>
        /// `type: text_to_image` for new integrations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyTextToImageSessionEnvelope> CreateTextToImageSessionAsync(

            global::CsmAi.LegacyTextToImageRequest request,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// (Legacy) Create a text-to-image session<br/>
        /// Legacy endpoint used by the official Python client for text-to-3D generation<br/>
        /// (pipeline is text → image → image-to-3D). Prefer `POST /v3/sessions/` with<br/>
        /// `type: text_to_image` for new integrations.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt.
        /// </param>
        /// <param name="styleId"></param>
        /// <param name="guidance">
        /// Guidance strength, serialized as a string in the legacy API.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyTextToImageSessionEnvelope> CreateTextToImageSessionAsync(
            string prompt,
            string? styleId = default,
            string? guidance = default,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}