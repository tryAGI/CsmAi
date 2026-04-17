
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyTextToImageRequest
    {
        /// <summary>
        /// Text prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        public string? StyleId { get; set; }

        /// <summary>
        /// Guidance strength, serialized as a string in the legacy API.<br/>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public string? Guidance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyTextToImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt.
        /// </param>
        /// <param name="styleId"></param>
        /// <param name="guidance">
        /// Guidance strength, serialized as a string in the legacy API.<br/>
        /// Default Value: 6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyTextToImageRequest(
            string prompt,
            string? styleId,
            string? guidance)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.StyleId = styleId;
            this.Guidance = guidance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyTextToImageRequest" /> class.
        /// </summary>
        public LegacyTextToImageRequest()
        {
        }
    }
}