using StrategyCase3.Interface;

namespace StrategyCase3.Domain;

public class ShoppingCart
{
    private readonly List<Item> _items = new List<Item>();

    public ShoppingCart()
    {
        
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void Pay(IPayment payment)
    {
        int amount = 0;

        foreach (var item in _items)
        {
            amount += item.Price;
        }
        
        payment.Pay(amount);
    }
}