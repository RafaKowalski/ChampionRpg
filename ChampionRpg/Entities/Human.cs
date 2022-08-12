using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Human : Champion
    {
        public void EscolhendoClasseHuman(Champion champion)
        {
            champion.Hp = 60;
            champion.Attack = 8;
        }
    }
}
