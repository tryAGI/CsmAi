#nullable enable

namespace CsmAi
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Cancel or delete a session
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CsmAi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CsmAi.SimpleMessageResponse> CancelSessionAsync(
            string sessionId,
            global::CsmAi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}