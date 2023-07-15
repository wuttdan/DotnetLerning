using Newtonsoft.Json;

namespace KafkaDemoLib.Models;

[JsonObject]
[Serializable]
public class SimpleModel
{
    public Ulid id { get; set; } = Ulid.NewUlid();
    public string? words { get; set; }
    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.None);
    }
    public string ToJsonIndented()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
