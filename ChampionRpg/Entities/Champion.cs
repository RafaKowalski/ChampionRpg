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
        public Champion()
        {
        }
        public Champion(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nHp: " + Hp;
        }
    }
}
