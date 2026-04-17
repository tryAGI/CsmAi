
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// C# SDK for [CSM AI](https://www.csm.ai/) (Common Sense Machines) — AI-powered 3D generation platform.<br/>
    /// Covers the unified v3 Sessions API (image-to-3D, text-to-image, image-to-kit, multiview-to-3D, retopology)<br/>
    /// as well as the legacy per-type session endpoints documented in the Python client.<br/>
    /// Manually authored from the [CSM API docs](https://docs.csm.ai/) and the<br/>
    /// [official Python SDK](https://github.com/CommonSenseMachines/csm-ai).<br/>
    /// Authentication uses an API key passed in the `x-api-key` header. Create a key from the<br/>
    /// [Cube Webapp](https://3d.csm.ai/) profile page.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICsmAiClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::CsmAi.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::CsmAi.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// User assets (completed sessions, downloads).
        /// </summary>
        public AssetsClient Assets { get; }

        /// <summary>
        /// Legacy image-to-3D session endpoints.
        /// </summary>
        public ImageTo3dClient ImageTo3d { get; }

        /// <summary>
        /// Unified v3 sessions API (create and manage any session type).
        /// </summary>
        public SessionsClient Sessions { get; }

        /// <summary>
        /// Legacy text-to-image session endpoints.
        /// </summary>
        public TextToImageClient TextToImage { get; }

    }
}