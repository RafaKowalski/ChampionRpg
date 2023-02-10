using ChampionRpg.Entities.Exceptions;

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

        public Champion(string name)
        {
            Name = name;
        }

        public Champion(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        private void LosingHp(Champion champion, int attack)
        {
            Random random = new Random();

            attack = random.Next(1, 10);

            champion.Hp -= attack;
            Console.WriteLine("Dano: " + attack.ToString());
        }

        public string Choice(string choice, Champion champion, int attack, Item item, Champion championChoose)
        {
            Inventory inventory = new Inventory();

            Console.WriteLine($"Campeão {Name} escolha uma ação: Ataque/Item");
            choice = Console.ReadLine();

            if (choice == "ataque")
            {
                Console.WriteLine();
                //Console.WriteLine($"Você atacou o inimigo com o ataque de {Attack}");
                champion.LosingHp(champion, attack);
            }

            else if (choice == "item")
            {
                Console.WriteLine();
                Console.WriteLine("Inventário");
                inventory.MostrandoItens(item);
                Console.WriteLine();
                item.ChoosingItem(item, championChoose);
                inventory.RemoveItem(item);
            }

            else
                throw new DomainException("Opção digitada incorretamente");

            return choice;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nHp: " + Hp; /*+ "\nAttack: " + Attack;*/
        }
    }
}
