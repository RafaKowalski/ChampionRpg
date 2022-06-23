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

        public void HealthPotion(Champion champion)
        {
            champion.Hp = champion.Hp + 6;
        }

        public void AttackPotion(Champion champion)
        {
            champion.Attack = champion.Attack + 2;
        }

        public void ChoosingItem(Item item, Champion champion)
        {
            Console.WriteLine("Selecione o item Health potion (hp) ou Attack potion (ap): ");
            item.Name = Console.ReadLine();
            if (item.Name == "hp")
                item.HealthPotion(champion);

            if (item.Name == "ap")
                item.AttackPotion(champion);
        }

        public override string ToString()
        {
            return Name + " " + Quantity;
        }
    }
}
