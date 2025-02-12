namespace StrategyCase3.Domain;

public class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int cost)
    {
        Name = name;
        Price = cost;
    }
}