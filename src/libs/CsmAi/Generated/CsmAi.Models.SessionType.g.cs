
#nullable enable

namespace CsmAi
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
    public enum SessionType
    {
        /// <summary>
        /// Generate a textured 3D mesh from a single image.
        /// </summary>
        ImageTo3d,
        /// <summary>
        /// Decompose a single image into a kit of modular 3D parts.
        /// </summary>
        ImageToKit,
        /// <summary>
        /// Generate a 3D mesh from multiple views.
        /// </summary>
        MultiviewTo3d,
        /// <summary>
        /// AI retopology of a high-poly mesh into clean low-poly topology.
        /// </summary>
        Retopology,
        /// <summary>
        /// Full 3D scene generation.
        /// </summary>
        Scene,
        /// <summary>
        /// Generate an image from a text prompt (first stage of text-to-3D).
        /// </summary>
        TextToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionType value)
        {
            return value switch
            {
                SessionType.ImageTo3d => "image_to_3d",
                SessionType.ImageToKit => "image_to_kit",
                SessionType.MultiviewTo3d => "multiview_to_3d",
                SessionType.Retopology => "retopology",
                SessionType.Scene => "scene",
                SessionType.TextToImage => "text_to_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionType? ToEnum(string value)
        {
            return value switch
            {
                "image_to_3d" => SessionType.ImageTo3d,
                "image_to_kit" => SessionType.ImageToKit,
                "multiview_to_3d" => SessionType.MultiviewTo3d,
                "retopology" => SessionType.Retopology,
                "scene" => SessionType.Scene,
                "text_to_image" => SessionType.TextToImage,
                _ => null,
            };
        }
    }
}