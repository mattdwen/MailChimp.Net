using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// This Converter is used to serialize MemberTag lists to the appropriate form
/// for PUT/POST requests. In these request, MailChimp requires just a simple array of tag names.
/// </summary>
public class MemberTagListJsonConverter : JsonConverter<List<MemberTag>>
{
    public override List<MemberTag> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, List<MemberTag> value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var tag in value)
        {
            writer.WriteStringValue(tag.Name);
        }
        writer.WriteEndArray();

        throw new NotImplementedException();
    }
}
