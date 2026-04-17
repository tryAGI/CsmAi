#nullable enable

namespace CsmAi
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// (Legacy) Get an image-to-3D session
        /// </summary>
        /// <param name="sessionCode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyImageTo3DSessionEnvelope> GetImageTo3DSessionAsync(
            string sessionCode,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}