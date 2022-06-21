using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Champion
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }

        public Champion()
        {
        }
        public Champion(string name, int hp, int attack, int defense)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public void LosingHp(Champion champion, int attack)
        {
            champion.Hp -= attack;
        }

        public string Choice(string choice, Champion champion, int attack, Item item, Champion champion1)
        {
            Console.WriteLine($"Campeão {Name} escolha uma ação: Ataque/Item");
            choice = Console.ReadLine();

            if (choice == "ataque")
            {
                Console.WriteLine();
                Console.WriteLine($"Você atacou o inimigo com o ataque de {Attack}");
                champion.LosingHp(champion, attack);
            }

            if (choice == "item")
            {
                Console.WriteLine();
                item.ChoosingItem(item, champion1);
            }

            return choice;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nHp: " + Hp + "\nAttack: " + Attack;
        }
    }
}
