using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionRpg.Entities
{
    public class Orc
    {
        public void EscolhendoClasseOrc(Champion champion)
        {
            champion.Hp = 85;
            champion.Attack = 3;
        }
    }
}
