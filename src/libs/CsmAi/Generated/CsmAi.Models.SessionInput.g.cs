
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Union of input fields across all session types. Which fields are required depends on `type`.<br/>
    /// - For `image_to_3d` / `image_to_kit`: `image_url` is required.<br/>
    /// - For `multiview_to_3d`: `image_urls` is required.<br/>
    /// - For `text_to_image`: `prompt` is required.<br/>
    /// - For `retopology`: `mesh_url` is required.<br/>
    /// - For `scene`: `prompt` is required; `image_url` and `style_id` are optional.
    /// </summary>
    public sealed partial class SessionInput
    {
        /// <summary>
        /// Public URL or base64 data URI of the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Multiple input image URLs (for `multiview_to_3d`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        public global::System.Collections.Generic.IList<string>? ImageUrls { get; set; }

        /// <summary>
        /// Text prompt (for `text_to_image`, `scene`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// URL of an input 3D mesh (for `retopology`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url")]
        public string? MeshUrl { get; set; }

        /// <summary>
        /// Optional style identifier influencing visual characteristics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        public string? StyleId { get; set; }

        /// <summary>
        /// Guidance strength (higher = stricter adherence to prompt).<br/>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Optional generation settings (parameters vary by session type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::CsmAi.SessionInputSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInput" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Public URL or base64 data URI of the input image.
        /// </param>
        /// <param name="imageUrls">
        /// Multiple input image URLs (for `multiview_to_3d`).
        /// </param>
        /// <param name="prompt">
        /// Text prompt (for `text_to_image`, `scene`).
        /// </param>
        /// <param name="meshUrl">
        /// URL of an input 3D mesh (for `retopology`).
        /// </param>
        /// <param name="styleId">
        /// Optional style identifier influencing visual characteristics.
        /// </param>
        /// <param name="guidance">
        /// Guidance strength (higher = stricter adherence to prompt).<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="settings">
        /// Optional generation settings (parameters vary by session type).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInput(
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? imageUrls,
            string? prompt,
            string? meshUrl,
            string? styleId,
            double? guidance,
            global::CsmAi.SessionInputSettings? settings)
        {
            this.ImageUrl = imageUrl;
            this.ImageUrls = imageUrls;
            this.Prompt = prompt;
            this.MeshUrl = meshUrl;
            this.StyleId = styleId;
            this.Guidance = guidance;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInput" /> class.
        /// </summary>
        public SessionInput()
        {
        }
    }
}