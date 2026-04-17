#nullable enable

namespace CsmAi
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// (Legacy) Get a text-to-image session
        /// </summary>
        /// <param name="sessionCode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.LegacyTextToImageSessionEnvelope> GetTextToImageSessionAsync(
            string sessionCode,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}