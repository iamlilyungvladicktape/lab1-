using System.Text.Json;

class Program
{
    static void Main(string[] atgs)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" }
        };

        List<int> keys = new List<int>(dict.Keys);
        List<string> values = new List<string>(dict.Values);

        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine(keys[i] + "-" + values[i]);
        }
        string json = JsonSerializer.Serialize(dict);
        File.WriteAllText("dictionary.json", json);
    }
}