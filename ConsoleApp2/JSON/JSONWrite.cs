using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace ConsoleApp2.JSON
{
    internal class JsonWrite
    {
        public void WriteJSON<T>(List<T> list, string path)
        {
            var newOptions = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string str = JsonSerializer.Serialize(list, newOptions);
            File.WriteAllText($"{path}.json", str);
        }
    }
}
