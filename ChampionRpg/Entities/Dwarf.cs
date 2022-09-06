using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Dwarf : Champion
    {
        public void EscolhendoClasseDwarf(Champion champion)
        {
            champion.Hp = 40;
            champion.Attack = 11;
        }
    }
}
