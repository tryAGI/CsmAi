
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Texture model variant for image-to-3D.
    /// </summary>
    public enum TextureModel
    {
        /// <summary>
        /// 
        /// </summary>
        Baked,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pbr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextureModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextureModel value)
        {
            return value switch
            {
                TextureModel.Baked => "baked",
                TextureModel.None => "none",
                TextureModel.Pbr => "pbr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextureModel? ToEnum(string value)
        {
            return value switch
            {
                "baked" => TextureModel.Baked,
                "none" => TextureModel.None,
                "pbr" => TextureModel.Pbr,
                _ => null,
            };
        }
    }
}