
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Standard envelope shape returned by legacy endpoints.
    /// </summary>
    public sealed partial class LegacyImageTo3DSessionEnvelope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::CsmAi.LegacyImageTo3DSession? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DSessionEnvelope" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="message"></param>
        /// <param name="error"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyImageTo3DSessionEnvelope(
            int? statusCode,
            string? message,
            string? error,
            global::CsmAi.LegacyImageTo3DSession? data)
        {
            this.StatusCode = statusCode;
            this.Message = message;
            this.Error = error;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DSessionEnvelope" /> class.
        /// </summary>
        public LegacyImageTo3DSessionEnvelope()
        {
        }
    }
}