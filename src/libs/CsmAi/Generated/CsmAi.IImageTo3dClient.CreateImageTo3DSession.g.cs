#nullable enable

namespace CsmAi
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// (Legacy) Create an image-to-3D session<br/>
        /// Legacy endpoint used by the official Python client. Prefer `POST /v3/sessions/` with<br/>
        /// `type: image_to_3d` for new integrations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyImageTo3DSessionEnvelope> CreateImageTo3DSessionAsync(

            global::CsmAi.LegacyImageTo3DRequest request,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// (Legacy) Create an image-to-3D session<br/>
        /// Legacy endpoint used by the official Python client. Prefer `POST /v3/sessions/` with<br/>
        /// `type: image_to_3d` for new integrations.
        /// </summary>
        /// <param name="imageUrl">
        /// Public URL or base64 data URI of the image.
        /// </param>
        /// <param name="geometryModel">
        /// Geometry model variant for image-to-3D.
        /// </param>
        /// <param name="textureModel">
        /// Texture model variant for image-to-3D.
        /// </param>
        /// <param name="creativity">
        /// Creativity level for image-to-3D.
        /// </param>
        /// <param name="autoRefine"></param>
        /// <param name="refineSpeed">
        /// Refinement speed for image-to-3D.
        /// </param>
        /// <param name="scaledBbox"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyImageTo3DSessionEnvelope> CreateImageTo3DSessionAsync(
            string imageUrl,
            global::CsmAi.GeometryModel? geometryModel = default,
            global::CsmAi.TextureModel? textureModel = default,
            global::CsmAi.Creativity? creativity = default,
            bool? autoRefine = default,
            global::CsmAi.RefineSpeed? refineSpeed = default,
            global::System.Collections.Generic.IList<double>? scaledBbox = default,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}