using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.models
{
        [Serializable]
        public class Games
        {
            public string Name { get; set; }
            public string Genre { get; set; }
            public int Price { get; set; }

        public Games(string Name, string Genre, int Price)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Price = Price;
        }
    }
}
