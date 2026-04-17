
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyImageTo3DRequest
    {
        /// <summary>
        /// Public URL or base64 data URI of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Geometry model variant for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geometry_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.GeometryModelJsonConverter))]
        public global::CsmAi.GeometryModel? GeometryModel { get; set; }

        /// <summary>
        /// Texture model variant for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.TextureModelJsonConverter))]
        public global::CsmAi.TextureModel? TextureModel { get; set; }

        /// <summary>
        /// Creativity level for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.CreativityJsonConverter))]
        public global::CsmAi.Creativity? Creativity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_refine")]
        public bool? AutoRefine { get; set; }

        /// <summary>
        /// Refinement speed for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refine_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.RefineSpeedJsonConverter))]
        public global::CsmAi.RefineSpeed? RefineSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaled_bbox")]
        public global::System.Collections.Generic.IList<double>? ScaledBbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyImageTo3DRequest(
            string imageUrl,
            global::CsmAi.GeometryModel? geometryModel,
            global::CsmAi.TextureModel? textureModel,
            global::CsmAi.Creativity? creativity,
            bool? autoRefine,
            global::CsmAi.RefineSpeed? refineSpeed,
            global::System.Collections.Generic.IList<double>? scaledBbox)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.GeometryModel = geometryModel;
            this.TextureModel = textureModel;
            this.Creativity = creativity;
            this.AutoRefine = autoRefine;
            this.RefineSpeed = refineSpeed;
            this.ScaledBbox = scaledBbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DRequest" /> class.
        /// </summary>
        public LegacyImageTo3DRequest()
        {
        }
    }
}