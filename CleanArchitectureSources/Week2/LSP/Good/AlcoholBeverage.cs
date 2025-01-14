namespace LSP.Good;

public class AlcoholBeverage : Beverage
{
    public override void Drink(int age)
    {
        if (age < 20)
        {
            Console.WriteLine("미성년자는 마실 수 없습니다.");
            return;
        }
        
        Console.WriteLine("마셔라 마셔~~");
    }
}