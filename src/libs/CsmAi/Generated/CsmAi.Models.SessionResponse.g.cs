
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// A session object with status, inputs, and outputs.
    /// </summary>
    public sealed partial class SessionResponse
    {
        /// <summary>
        /// Unique identifier of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Legacy session code (e.g. `SESSION_XXXXXXXXXX_XXXXXXX`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_code")]
        public string? SessionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

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
        public global::CsmAi.SessionType? Type { get; set; }

        /// <summary>
        /// Status of a CSM session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.SessionStatusJsonConverter))]
        public global::CsmAi.SessionStatus? Status { get; set; }

        /// <summary>
        /// Status of a CSM session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CsmAi.JsonConverters.SessionStatusJsonConverter))]
        public global::CsmAi.SessionStatus? SessionStatus { get; set; }

        /// <summary>
        /// Progress percentage (0-100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_done")]
        public double? PercentDone { get; set; }

        /// <summary>
        /// ISO-8601 timestamp or millisecond epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Union of input fields across all session types. Which fields are required depends on `type`.<br/>
        /// - For `image_to_3d` / `image_to_kit`: `image_url` is required.<br/>
        /// - For `multiview_to_3d`: `image_urls` is required.<br/>
        /// - For `text_to_image`: `prompt` is required.<br/>
        /// - For `retopology`: `mesh_url` is required.<br/>
        /// - For `scene`: `prompt` is required; `image_url` and `style_id` are optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::CsmAi.SessionInput? Input { get; set; }

        /// <summary>
        /// Union of output fields across all session types. Which fields are populated depends on `type`<br/>
        /// and session status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::CsmAi.SessionOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the session.
        /// </param>
        /// <param name="sessionCode">
        /// Legacy session code (e.g. `SESSION_XXXXXXXXXX_XXXXXXX`).
        /// </param>
        /// <param name="userId"></param>
        /// <param name="type">
        /// Type of CSM session — determines the generation performed and the required input fields.<br/>
        /// - `image_to_3d`: Generate a textured 3D mesh from a single image.<br/>
        /// - `multiview_to_3d`: Generate a 3D mesh from multiple views.<br/>
        /// - `text_to_image`: Generate an image from a text prompt (first stage of text-to-3D).<br/>
        /// - `image_to_kit`: Decompose a single image into a kit of modular 3D parts.<br/>
        /// - `retopology`: AI retopology of a high-poly mesh into clean low-poly topology.<br/>
        /// - `scene`: Full 3D scene generation.
        /// </param>
        /// <param name="status">
        /// Status of a CSM session.
        /// </param>
        /// <param name="sessionStatus">
        /// Status of a CSM session.
        /// </param>
        /// <param name="percentDone">
        /// Progress percentage (0-100).
        /// </param>
        /// <param name="createdAt">
        /// ISO-8601 timestamp or millisecond epoch.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="input">
        /// Union of input fields across all session types. Which fields are required depends on `type`.<br/>
        /// - For `image_to_3d` / `image_to_kit`: `image_url` is required.<br/>
        /// - For `multiview_to_3d`: `image_urls` is required.<br/>
        /// - For `text_to_image`: `prompt` is required.<br/>
        /// - For `retopology`: `mesh_url` is required.<br/>
        /// - For `scene`: `prompt` is required; `image_url` and `style_id` are optional.
        /// </param>
        /// <param name="output">
        /// Union of output fields across all session types. Which fields are populated depends on `type`<br/>
        /// and session status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionResponse(
            string? id,
            string? sessionCode,
            string? userId,
            global::CsmAi.SessionType? type,
            global::CsmAi.SessionStatus? status,
            global::CsmAi.SessionStatus? sessionStatus,
            double? percentDone,
            string? createdAt,
            string? updatedAt,
            global::CsmAi.SessionInput? input,
            global::CsmAi.SessionOutput? output)
        {
            this.Id = id;
            this.SessionCode = sessionCode;
            this.UserId = userId;
            this.Type = type;
            this.Status = status;
            this.SessionStatus = sessionStatus;
            this.PercentDone = percentDone;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResponse" /> class.
        /// </summary>
        public SessionResponse()
        {
        }
    }
}