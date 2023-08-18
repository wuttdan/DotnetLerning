using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Xml.Linq;

namespace Domain.Extension;

public static class ConvExtension
{
    public static string ObjToJson<T>(this T source, bool isIndented = false, bool isIgnoreNull = false)
    {
        var indented = isIndented ? Formatting.Indented : Formatting.None;
        if (isIgnoreNull)
        {
            return JsonConvert.SerializeObject(source, new JsonSerializerSettings()
            {
                Formatting = indented,
                NullValueHandling = NullValueHandling.Ignore
            });
        }
        return JsonConvert.SerializeObject(source, indented);
    }

    public static T? JsonToObj<T>(this string jsonText)
    {
        var obj = JsonConvert.DeserializeObject<T>(jsonText) ?? default;
        return obj;
    }

    public static bool IsValidJson(this string anyString, bool displayDebug = false)
    {
        try
        {
            _ = JToken.Parse(anyString);
            return true;
        }
        catch (JsonReaderException jex)
        {
            if (displayDebug)
                Debug.WriteLine(string.Format("Json_Extension->JsonReaderException: {0}", jex));
        }
        catch (Exception ex)
        {
            if (displayDebug)
                Debug.WriteLine(string.Format("Json_Extension->Exception: {0}", ex));
        }
        return false;
    }

    public static bool IsValidXml(this string anyString, bool displayDebug = false)
    {
        try
        {
            _ = XElement.Parse(anyString);
            return true;
        }
        catch (Exception ex)
        {
            if (displayDebug)
                Debug.WriteLine(string.Format("Json_Extension->Exception: {0}", ex));
        }
        return false;
    }
}
