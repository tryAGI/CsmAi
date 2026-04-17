
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyImageTo3DSession
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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.SessionStatusJsonConverter))]
        public global::CsmAi.SessionStatus? SessionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_done")]
        public double? PercentDone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_obj")]
        public string? MeshUrlObj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_glb")]
        public string? MeshUrlGlb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_fbx")]
        public string? MeshUrlFbx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_usdz")]
        public string? MeshUrlUsdz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_zip")]
        public string? MeshUrlZip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spin_video_url")]
        public string? SpinVideoUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="LegacyImageTo3DSession" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sessionCode"></param>
        /// <param name="sessionStatus">
        /// Status of a CSM session.
        /// </param>
        /// <param name="percentDone"></param>
        /// <param name="imageUrl"></param>
        /// <param name="meshUrlObj"></param>
        /// <param name="meshUrlGlb"></param>
        /// <param name="meshUrlFbx"></param>
        /// <param name="meshUrlUsdz"></param>
        /// <param name="meshUrlZip"></param>
        /// <param name="spinVideoUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyImageTo3DSession(
            string? id,
            string? sessionCode,
            global::CsmAi.SessionStatus? sessionStatus,
            double? percentDone,
            string? imageUrl,
            string? meshUrlObj,
            string? meshUrlGlb,
            string? meshUrlFbx,
            string? meshUrlUsdz,
            string? meshUrlZip,
            string? spinVideoUrl,
            string? createdAt,
            string? updatedAt)
        {
            this.Id = id;
            this.SessionCode = sessionCode;
            this.SessionStatus = sessionStatus;
            this.PercentDone = percentDone;
            this.ImageUrl = imageUrl;
            this.MeshUrlObj = meshUrlObj;
            this.MeshUrlGlb = meshUrlGlb;
            this.MeshUrlFbx = meshUrlFbx;
            this.MeshUrlUsdz = meshUrlUsdz;
            this.MeshUrlZip = meshUrlZip;
            this.SpinVideoUrl = spinVideoUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DSession" /> class.
        /// </summary>
        public LegacyImageTo3DSession()
        {
        }
    }
}