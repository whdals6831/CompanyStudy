using OCP.Good;
using Fruit = OCP.Bad.Fruit;
using SeasonManager = OCP.Bad.SeasonManager;

namespace OCP;

public class Program
{
    public static void Main()
    {
        // Bad Case
        var seasonManager = new SeasonManager();
        
        var cherry = new Fruit("Cherry");
        var mango = new Fruit("Mango");
        var melon = new Fruit("Melon");
        var strawberry = new Fruit("Strawberry");

        seasonManager.PrintFruitSeason(cherry);
        seasonManager.PrintFruitSeason(mango);
        seasonManager.PrintFruitSeason(melon);
        seasonManager.PrintFruitSeason(strawberry);

        // Good Case
        var seasonManager2 = new Good.SeasonManager();

        var cherry2 = new Cherry();
        var mango2 = new Mango();
        var melon2 = new Melon();
        var strawberry2 = new Strawberry();
        
        seasonManager2.PrintFruitSeason(cherry2);
        seasonManager2.PrintFruitSeason(mango2);
        seasonManager2.PrintFruitSeason(melon2);
        seasonManager2.PrintFruitSeason(strawberry2);
    }
}