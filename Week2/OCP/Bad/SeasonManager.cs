namespace OCP.Bad;

public class SeasonManager
{
    public void PrintFruitSeason(Fruit fruit)
    {
        Console.WriteLine(GetFruitSeason(fruit));
    }
    
    private string GetFruitSeason(Fruit fruit) => fruit.GetName() switch
    {
        "Cherry" => "1월",
        "Mango" => "3월",
        "Melon" => "6월",
        "Strawberry" => "12월",
        _ => throw new InvalidDataException()
    };
}