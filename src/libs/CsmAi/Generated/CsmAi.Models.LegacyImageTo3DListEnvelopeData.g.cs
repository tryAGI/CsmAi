
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyImageTo3DListEnvelopeData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::CsmAi.LegacyImageTo3DSession>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DListEnvelopeData" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyImageTo3DListEnvelopeData(
            global::System.Collections.Generic.IList<global::CsmAi.LegacyImageTo3DSession>? results,
            int? total)
        {
            this.Results = results;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyImageTo3DListEnvelopeData" /> class.
        /// </summary>
        public LegacyImageTo3DListEnvelopeData()
        {
        }
    }
}