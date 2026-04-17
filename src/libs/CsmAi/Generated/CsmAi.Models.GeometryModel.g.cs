
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Geometry model variant for image-to-3D.
    /// </summary>
    public enum GeometryModel
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeometryModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeometryModel value)
        {
            return value switch
            {
                GeometryModel.Base => "base",
                GeometryModel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeometryModel? ToEnum(string value)
        {
            return value switch
            {
                "base" => GeometryModel.Base,
                "turbo" => GeometryModel.Turbo,
                _ => null,
            };
        }
    }
}