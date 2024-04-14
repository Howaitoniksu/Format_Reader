using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace ConsoleApp2.YAML
{
    internal class Writeyaml
    {
        public void WriteYAML<T>(List<T> list, string path)
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(list);
            File.WriteAllText($"{path}.yaml", yaml);
        }
    }
}
