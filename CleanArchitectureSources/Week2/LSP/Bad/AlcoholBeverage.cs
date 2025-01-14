namespace LSP.Bad;

public class AlcoholBeverage : Beverage
{
    public override void Drink()
    {
        throw new Exception("술은 성인만 마실 수 있습니다.");
    }
}