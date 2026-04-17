#nullable enable

namespace CsmAi
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// (Legacy) List image-to-3D sessions
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyImageTo3DListEnvelope> ListImageTo3DSessionsAsync(
            int? limit = default,
            int? page = default,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}