
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Creativity level for image-to-3D.
    /// </summary>
    public enum Creativity
    {
        /// <summary>
        /// 
        /// </summary>
        Highest,
        /// <summary>
        /// 
        /// </summary>
        Lowest,
        /// <summary>
        /// 
        /// </summary>
        Moderate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreativityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Creativity value)
        {
            return value switch
            {
                Creativity.Highest => "highest",
                Creativity.Lowest => "lowest",
                Creativity.Moderate => "moderate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Creativity? ToEnum(string value)
        {
            return value switch
            {
                "highest" => Creativity.Highest,
                "lowest" => Creativity.Lowest,
                "moderate" => Creativity.Moderate,
                _ => null,
            };
        }
    }
}