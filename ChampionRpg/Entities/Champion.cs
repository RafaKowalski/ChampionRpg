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
        public int Defense { get; set; }

        public Champion()
        {
        }
        public Champion(string name, int hp, int attack, int defense)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Defense = defense;
        }

        public void LosingHp(Champion victim, int attack)
        {
            victim.Hp += victim.Defense - attack;
        }

        public string Choice(string choice, Champion victim, int attack)
        {
            Console.WriteLine($"Campeão {Name} escolha uma ação: Ataque/Defense");
            choice = Console.ReadLine();

            if (choice == "ataque")
            {
                Console.WriteLine($"Você atacou o inimigo com o ataque de {Attack}");
                victim.LosingHp(victim, attack);
            }

            if (choice == "defense")
            {
                Console.WriteLine($"Você aumentou sua defesa em +1 neste turno");
                Defense++;
                Console.WriteLine("Sua atual defesa é de: " + Defense);
            }

            return choice;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nHp: " + Hp + "\nAttack: " + Attack + "\nDefense: " + Defense;
        }
    }
}
