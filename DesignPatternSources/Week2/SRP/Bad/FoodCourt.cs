namespace SRP.Bad;

/// <summary>
/// 기본 맵기 함수를 공유하고 있어서
/// 떡볶이 쪽에서 기본 맵기를 바꿔버리면
/// 라면도 덩달아서 매워진다.
/// </summary>
public class FoodCourt
{
    public Ramen MakeRamen()
    {
        var ramen = new Ramen();
        SetDefaultSpicy(ramen);

        return ramen;
    }

    public Tteokbokki MakeTteokbokki()
    {
        var tteokbokki = new Tteokbokki();
        SetDefaultSpicy(tteokbokki);

        return tteokbokki;
    }

    private void SetDefaultSpicy(Food food)
    {
        food.Spicy = 0.7;
    }
}