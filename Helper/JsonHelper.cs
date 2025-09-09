using System.Text.Json;

namespace StoreAppProject.Helper;

static class JsonHelper
{
    private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

    public static void SaveToJson<T>(List<T> data, string fileName)
    {
        string json = JsonSerializer.Serialize(data, options);
        File.WriteAllText(fileName, json);
    }

    public static List<T> LoadFromJson<T>(string fileName)
    {
        if (!File.Exists(fileName))
            return new List<T>();

        string json = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }
}