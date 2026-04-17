
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace CsmAi
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::CsmAi.JsonConverters.SessionTypeJsonConverter),

            typeof(global::CsmAi.JsonConverters.SessionTypeNullableJsonConverter),

            typeof(global::CsmAi.JsonConverters.SessionStatusJsonConverter),

            typeof(global::CsmAi.JsonConverters.SessionStatusNullableJsonConverter),

            typeof(global::CsmAi.JsonConverters.GeometryModelJsonConverter),

            typeof(global::CsmAi.JsonConverters.GeometryModelNullableJsonConverter),

            typeof(global::CsmAi.JsonConverters.TextureModelJsonConverter),

            typeof(global::CsmAi.JsonConverters.TextureModelNullableJsonConverter),

            typeof(global::CsmAi.JsonConverters.CreativityJsonConverter),

            typeof(global::CsmAi.JsonConverters.CreativityNullableJsonConverter),

            typeof(global::CsmAi.JsonConverters.RefineSpeedJsonConverter),

            typeof(global::CsmAi.JsonConverters.RefineSpeedNullableJsonConverter),

            typeof(global::CsmAi.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SessionType), TypeInfoPropertyName = "SessionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SessionStatus), TypeInfoPropertyName = "SessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.GeometryModel), TypeInfoPropertyName = "GeometryModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.TextureModel), TypeInfoPropertyName = "TextureModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.Creativity), TypeInfoPropertyName = "Creativity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.RefineSpeed), TypeInfoPropertyName = "RefineSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.CreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SessionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SessionInputSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SessionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CsmAi.KitPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.KitPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.ListSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CsmAi.SessionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyImageTo3DRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyImageTo3DSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyImageTo3DSessionEnvelope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyImageTo3DListEnvelope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyImageTo3DListEnvelopeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::CsmAi.LegacyImageTo3DSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyTextToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyTextToImageSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.LegacyTextToImageSessionEnvelope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.SimpleMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::CsmAi.CreditsBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CsmAi.KitPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CsmAi.SessionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::CsmAi.LegacyImageTo3DSession>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}