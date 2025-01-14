namespace SRP.Good;

public class FoodCourt
{
    public Ramen MakeRamen()
    {
        var ramen = new Ramen();
        ramen.SetSpicyFlavor(50);

        return ramen;
    }

    public Tteokbokki MakeTteokbokki()
    {
        var tteokbokki = new Tteokbokki();
        tteokbokki.SetSpicyFlavor(999);

        return tteokbokki;
    }
}