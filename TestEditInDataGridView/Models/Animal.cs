using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEditInDataGridView.Models
{
    public class Animal
    {
        public static string[] LegOptions = { "2 Legs", "4 Legs", "8 Legs", "1000 Legs"};

        public int Id { get; set; }
        public string Name { get; set; }
        public string Legs { get; set; }

        public Animal()
        {
            this.Name = "";
        }

        public Animal(int _id, string _name, string _legs)
        {
            Id = _id;
            Name = _name;
            Legs = _legs;
        }
    }
}
