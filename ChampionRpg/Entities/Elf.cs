using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Elf : Champion
    {
        public void EscolhendoClasseElf(Champion champion)
        {
            champion.Hp = 70;
            champion.Attack = 7;
        }
    }
}
