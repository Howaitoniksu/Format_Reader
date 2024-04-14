using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ConsoleApp2.YAML
{
    internal class Readyaml
    {
        public List<T> ReadYAML<T>(string path)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            using (StreamReader sr = new StreamReader($"{path}.yaml"))
            {
                string yaml = sr.ReadToEnd();
                List<T> list1 = new List<T>();
                list1 = deserializer.Deserialize<List<T>>(yaml);
                return list1;
            };

        }
    }
}
