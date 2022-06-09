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
        public override string ToString()
        {
            return "Name: " + Name + "\nHp: " + Hp + "\nAttack: " + Attack + "\nDefense: " + Defense;
        }
    }
}
