using System.Text.Json;

namespace ConsoleApp2.JSON
{
    internal class JsonRead
    {
        public List<T> ReadJSON<T>(string path)
        {
            List<T> list = new List<T>();
            using (FileStream jsonStream = new FileStream($"{path}.json", FileMode.Open))
            {
                list = JsonSerializer.Deserialize<List<T>>(jsonStream);
            }
            return list;
        }
    }
}
