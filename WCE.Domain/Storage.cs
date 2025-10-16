using System.Text.Json;
using System.Text.Encodings.Web;


namespace WCE.Domain;

public class Storage
{
    private static JsonSerializerOptions _options = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
    
    public static List<Course> ReadCoursesJson(string path)
    {
        var json = File.ReadAllText(path);
        var courses = JsonSerializer.Deserialize<List<Course>>(json, _options);
        return courses ?? new List<Course>();
    }

    public static void WriteCoursesJson(string path, List<Course> course)
    {
        var json = JsonSerializer.Serialize(course, _options);
        File.WriteAllText(path, json);
    }
}
