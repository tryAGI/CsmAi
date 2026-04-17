
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Union of output fields across all session types. Which fields are populated depends on `type`<br/>
    /// and session status.
    /// </summary>
    public sealed partial class SessionOutput
    {
        /// <summary>
        /// URL of the generated image (for `text_to_image`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Generic mesh URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url")]
        public string? MeshUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_mesh_url_glb")]
        public string? PreviewMeshUrlGlb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spin_video_url")]
        public string? SpinVideoUrl { get; set; }

        /// <summary>
        /// Kit parts (for `image_to_kit`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        public global::System.Collections.Generic.IList<global::CsmAi.KitPart>? Parts { get; set; }

        /// <summary>
        /// URL of the generated 3D scene (for `scene`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scene_url")]
        public string? SceneUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionOutput" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// URL of the generated image (for `text_to_image`).
        /// </param>
        /// <param name="meshUrl">
        /// Generic mesh URL.
        /// </param>
        /// <param name="meshUrlObj"></param>
        /// <param name="meshUrlGlb"></param>
        /// <param name="meshUrlFbx"></param>
        /// <param name="meshUrlUsdz"></param>
        /// <param name="meshUrlZip"></param>
        /// <param name="previewMeshUrlGlb"></param>
        /// <param name="spinVideoUrl"></param>
        /// <param name="parts">
        /// Kit parts (for `image_to_kit`).
        /// </param>
        /// <param name="sceneUrl">
        /// URL of the generated 3D scene (for `scene`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionOutput(
            string? imageUrl,
            string? meshUrl,
            string? meshUrlObj,
            string? meshUrlGlb,
            string? meshUrlFbx,
            string? meshUrlUsdz,
            string? meshUrlZip,
            string? previewMeshUrlGlb,
            string? spinVideoUrl,
            global::System.Collections.Generic.IList<global::CsmAi.KitPart>? parts,
            string? sceneUrl)
        {
            this.ImageUrl = imageUrl;
            this.MeshUrl = meshUrl;
            this.MeshUrlObj = meshUrlObj;
            this.MeshUrlGlb = meshUrlGlb;
            this.MeshUrlFbx = meshUrlFbx;
            this.MeshUrlUsdz = meshUrlUsdz;
            this.MeshUrlZip = meshUrlZip;
            this.PreviewMeshUrlGlb = previewMeshUrlGlb;
            this.SpinVideoUrl = spinVideoUrl;
            this.Parts = parts;
            this.SceneUrl = sceneUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionOutput" /> class.
        /// </summary>
        public SessionOutput()
        {
        }
    }
}