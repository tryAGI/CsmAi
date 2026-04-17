
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyTextToImageSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_code")]
        public string? SessionCode { get; set; }

        /// <summary>
        /// Status of a CSM session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.SessionStatusJsonConverter))]
        public global::CsmAi.SessionStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        public string? StyleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public string? Guidance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyTextToImageSession" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sessionCode"></param>
        /// <param name="status">
        /// Status of a CSM session.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="imageUrl"></param>
        /// <param name="styleId"></param>
        /// <param name="guidance"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyTextToImageSession(
            string? id,
            string? sessionCode,
            global::CsmAi.SessionStatus? status,
            string? prompt,
            string? imageUrl,
            string? styleId,
            string? guidance,
            string? createdAt,
            string? updatedAt)
        {
            this.Id = id;
            this.SessionCode = sessionCode;
            this.Status = status;
            this.Prompt = prompt;
            this.ImageUrl = imageUrl;
            this.StyleId = styleId;
            this.Guidance = guidance;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyTextToImageSession" /> class.
        /// </summary>
        public LegacyTextToImageSession()
        {
        }
    }
}