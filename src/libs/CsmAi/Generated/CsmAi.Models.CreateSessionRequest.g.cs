
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionRequest
    {
        /// <summary>
        /// Type of CSM session — determines the generation performed and the required input fields.<br/>
        /// - `image_to_3d`: Generate a textured 3D mesh from a single image.<br/>
        /// - `multiview_to_3d`: Generate a 3D mesh from multiple views.<br/>
        /// - `text_to_image`: Generate an image from a text prompt (first stage of text-to-3D).<br/>
        /// - `image_to_kit`: Decompose a single image into a kit of modular 3D parts.<br/>
        /// - `retopology`: AI retopology of a high-poly mesh into clean low-poly topology.<br/>
        /// - `scene`: Full 3D scene generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.SessionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CsmAi.SessionType Type { get; set; }

        /// <summary>
        /// Union of input fields across all session types. Which fields are required depends on `type`.<br/>
        /// - For `image_to_3d` / `image_to_kit`: `image_url` is required.<br/>
        /// - For `multiview_to_3d`: `image_urls` is required.<br/>
        /// - For `text_to_image`: `prompt` is required.<br/>
        /// - For `retopology`: `mesh_url` is required.<br/>
        /// - For `scene`: `prompt` is required; `image_url` and `style_id` are optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CsmAi.SessionInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of CSM session — determines the generation performed and the required input fields.<br/>
        /// - `image_to_3d`: Generate a textured 3D mesh from a single image.<br/>
        /// - `multiview_to_3d`: Generate a 3D mesh from multiple views.<br/>
        /// - `text_to_image`: Generate an image from a text prompt (first stage of text-to-3D).<br/>
        /// - `image_to_kit`: Decompose a single image into a kit of modular 3D parts.<br/>
        /// - `retopology`: AI retopology of a high-poly mesh into clean low-poly topology.<br/>
        /// - `scene`: Full 3D scene generation.
        /// </param>
        /// <param name="input">
        /// Union of input fields across all session types. Which fields are required depends on `type`.<br/>
        /// - For `image_to_3d` / `image_to_kit`: `image_url` is required.<br/>
        /// - For `multiview_to_3d`: `image_urls` is required.<br/>
        /// - For `text_to_image`: `prompt` is required.<br/>
        /// - For `retopology`: `mesh_url` is required.<br/>
        /// - For `scene`: `prompt` is required; `image_url` and `style_id` are optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionRequest(
            global::CsmAi.SessionType type,
            global::CsmAi.SessionInput input)
        {
            this.Type = type;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        public CreateSessionRequest()
        {
        }
    }
}