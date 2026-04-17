
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Refinement speed for image-to-3D.
    /// </summary>
    public enum RefineSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Slow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefineSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefineSpeed value)
        {
            return value switch
            {
                RefineSpeed.Fast => "fast",
                RefineSpeed.Slow => "slow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefineSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => RefineSpeed.Fast,
                "slow" => RefineSpeed.Slow,
                _ => null,
            };
        }
    }
}