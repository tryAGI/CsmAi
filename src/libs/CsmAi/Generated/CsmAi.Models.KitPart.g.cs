
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KitPart
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_glb")]
        public string? MeshUrlGlb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_obj")]
        public string? MeshUrlObj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_url_fbx")]
        public string? MeshUrlFbx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KitPart" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="meshUrlGlb"></param>
        /// <param name="meshUrlObj"></param>
        /// <param name="meshUrlFbx"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KitPart(
            string? id,
            string? name,
            string? meshUrlGlb,
            string? meshUrlObj,
            string? meshUrlFbx)
        {
            this.Id = id;
            this.Name = name;
            this.MeshUrlGlb = meshUrlGlb;
            this.MeshUrlObj = meshUrlObj;
            this.MeshUrlFbx = meshUrlFbx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KitPart" /> class.
        /// </summary>
        public KitPart()
        {
        }
    }
}