using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item()
        {
        }
        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
