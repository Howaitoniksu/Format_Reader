using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2.XML
{
    internal class Writexml 
    {
        public void WriteXML<T>(List<T> list, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlFileStream = new FileStream($"{path}.xml", FileMode.Create))
            {
                serializer.Serialize(xmlFileStream, list);
            }
        }
    }
}
