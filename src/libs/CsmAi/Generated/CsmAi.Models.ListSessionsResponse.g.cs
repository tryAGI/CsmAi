
#nullable enable

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSessionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::CsmAi.SessionResponse>? Results { get; set; }

        /// <summary>
        /// Total number of sessions matching the filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionsResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="total">
        /// Total number of sessions matching the filter.
        /// </param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSessionsResponse(
            global::System.Collections.Generic.IList<global::CsmAi.SessionResponse>? results,
            int? total,
            int? page,
            int? limit)
        {
            this.Results = results;
            this.Total = total;
            this.Page = page;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionsResponse" /> class.
        /// </summary>
        public ListSessionsResponse()
        {
        }
    }
}