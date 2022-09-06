namespace ChampionRpg.Entities
{
    public class Inventory
    {
        public List<Item> Items { get; set; }
        public void MostrandoItens()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item("Health Potion", 999));
            list.Add(new Item("Attack Potion", 999));

            foreach (Item item in list)
                Console.WriteLine(item);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
    }
}
