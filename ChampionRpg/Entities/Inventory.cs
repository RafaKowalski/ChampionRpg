namespace ChampionRpg.Entities
{
    public class Inventory
    {
        public List<Item> Items { get; set; } = new List<Item> { };
        public void MostrandoItens(Item item)
        {
            Items.Add(new Item("Health Potion", 999));
            Items.Add(new Item("Attack Potion", 999));

            Items.ForEach(Console.WriteLine);
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
