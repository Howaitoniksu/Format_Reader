using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ConsoleApp2.models;

namespace ConsoleApp2.XML
{
    internal class Readxml
    {
        public List<T> ReadXML<T>(string path)
        {
            List<T> list = new List<T>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Games>));
            using (var xmlFileStream = new FileStream($"{path}.xml", FileMode.Open))
            {
                    list = (List<T>)formatter.Deserialize(xmlFileStream);
            }
            return list;
        }
    }
}
