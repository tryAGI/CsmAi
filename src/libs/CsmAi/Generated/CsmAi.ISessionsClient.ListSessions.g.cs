#nullable enable

namespace CsmAi
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// List sessions<br/>
        /// List sessions for the current user with optional pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="type">
        /// Type of CSM session — determines the generation performed and the required input fields.<br/>
        /// - `image_to_3d`: Generate a textured 3D mesh from a single image.<br/>
        /// - `multiview_to_3d`: Generate a 3D mesh from multiple views.<br/>
        /// - `text_to_image`: Generate an image from a text prompt (first stage of text-to-3D).<br/>
        /// - `image_to_kit`: Decompose a single image into a kit of modular 3D parts.<br/>
        /// - `retopology`: AI retopology of a high-poly mesh into clean low-poly topology.<br/>
        /// - `scene`: Full 3D scene generation.
        /// </param>
        /// <param name="status">
        /// Status of a CSM session.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.ListSessionsResponse> ListSessionsAsync(
            int? limit = default,
            int? page = default,
            global::CsmAi.SessionType? type = default,
            global::CsmAi.SessionStatus? status = default,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}