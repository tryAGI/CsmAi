
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// Status of a CSM session.
    /// </summary>
    public enum SessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionStatus value)
        {
            return value switch
            {
                SessionStatus.Cancelled => "cancelled",
                SessionStatus.Complete => "complete",
                SessionStatus.Completed => "completed",
                SessionStatus.Failed => "failed",
                SessionStatus.InProgress => "in_progress",
                SessionStatus.Incomplete => "incomplete",
                SessionStatus.Processing => "processing",
                SessionStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => SessionStatus.Cancelled,
                "complete" => SessionStatus.Complete,
                "completed" => SessionStatus.Completed,
                "failed" => SessionStatus.Failed,
                "in_progress" => SessionStatus.InProgress,
                "incomplete" => SessionStatus.Incomplete,
                "processing" => SessionStatus.Processing,
                "queued" => SessionStatus.Queued,
                _ => null,
            };
        }
    }
}