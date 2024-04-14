using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.models
{

    [Serializable]
    public class Smithery
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public Smithery(string Name, string Description, string Type, int Weight, int Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.Weight = Weight;
            this.Price = Price;
        }
    }
}
