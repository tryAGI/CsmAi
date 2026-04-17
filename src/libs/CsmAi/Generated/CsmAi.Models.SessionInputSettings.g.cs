
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Optional generation settings (parameters vary by session type).
    /// </summary>
    public sealed partial class SessionInputSettings
    {
        /// <summary>
        /// Creativity level for image-to-3D.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.CreativityJsonConverter))]
        public global::CsmAi.Creativity? Creativity { get; set; }

        /// <summary>
        /// Default Value: false
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
        /// Target dimensions in meters `[x, y, z]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaled_bbox")]
        public global::System.Collections.Generic.IList<double>? ScaledBbox { get; set; }

        /// <summary>
        /// Output texture resolution (e.g. 1024, 2048).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// Seed for deterministic generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputSettings" /> class.
        /// </summary>
        /// <param name="creativity">
        /// Creativity level for image-to-3D.
        /// </param>
        /// <param name="autoRefine">
        /// Default Value: false
        /// </param>
        /// <param name="refineSpeed">
        /// Refinement speed for image-to-3D.
        /// </param>
        /// <param name="geometryModel">
        /// Geometry model variant for image-to-3D.
        /// </param>
        /// <param name="textureModel">
        /// Texture model variant for image-to-3D.
        /// </param>
        /// <param name="scaledBbox">
        /// Target dimensions in meters `[x, y, z]`.
        /// </param>
        /// <param name="resolution">
        /// Output texture resolution (e.g. 1024, 2048).
        /// </param>
        /// <param name="seed">
        /// Seed for deterministic generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInputSettings(
            global::CsmAi.Creativity? creativity,
            bool? autoRefine,
            global::CsmAi.RefineSpeed? refineSpeed,
            global::CsmAi.GeometryModel? geometryModel,
            global::CsmAi.TextureModel? textureModel,
            global::System.Collections.Generic.IList<double>? scaledBbox,
            int? resolution,
            int? seed)
        {
            this.Creativity = creativity;
            this.AutoRefine = autoRefine;
            this.RefineSpeed = refineSpeed;
            this.GeometryModel = geometryModel;
            this.TextureModel = textureModel;
            this.ScaledBbox = scaledBbox;
            this.Resolution = resolution;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputSettings" /> class.
        /// </summary>
        public SessionInputSettings()
        {
        }
    }
}