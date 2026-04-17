
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsBalanceResponse
    {
        /// <summary>
        /// Current credit balance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Subscription plan name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsBalanceResponse" /> class.
        /// </summary>
        /// <param name="credits">
        /// Current credit balance.
        /// </param>
        /// <param name="plan">
        /// Subscription plan name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsBalanceResponse(
            double? credits,
            string? plan)
        {
            this.Credits = credits;
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsBalanceResponse" /> class.
        /// </summary>
        public CreditsBalanceResponse()
        {
        }
    }
}