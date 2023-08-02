using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Application.Common.Core;

public sealed class JsonDateTimeConverter : JsonConverter<DateTime>
{
    public const string FORMAT_SQL_DATETIME = "dd/MM/yyyy HH:mm:ss";
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Debug.Assert(typeToConvert == typeof(DateTime));
        return DateTime.Parse(reader.GetString());
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(FORMAT_SQL_DATETIME));
    }
}
