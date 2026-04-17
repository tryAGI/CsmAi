#nullable enable

namespace CsmAi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreativityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CsmAi.Creativity>
    {
        /// <inheritdoc />
        public override global::CsmAi.Creativity Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::CsmAi.CreativityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CsmAi.Creativity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CsmAi.Creativity);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CsmAi.Creativity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::CsmAi.CreativityExtensions.ToValueString(value));
        }
    }
}
