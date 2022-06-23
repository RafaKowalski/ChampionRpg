using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Inventory
    {
        public List<Item> Items;

        public Inventory()
        {
            Items = new List<Item>();
        }

        public List<Item> AdicionandoItem(Item item)
        {
            List<Item> list = new List<Item>();
            list.Add(item);
            return list;
        }

        public List<Item> PerdendoItem(Item item)
        {
            List<Item> list = new List<Item>();
            list.Remove(item);
            return list;
        }

        public List<Item> MostrandoInventário(Item item)
        {
           List <Item> list = new List<Item>();
            foreach (Item item2 in Items)
                Console.WriteLine(item2);
            return list;
        }
    }
}
