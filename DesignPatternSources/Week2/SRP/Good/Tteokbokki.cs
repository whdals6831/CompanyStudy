namespace SRP.Good;

public class Tteokbokki : Food, ITasteManager
{
    public string RickCake { get; set; } = "rice";

    public void SetSpicyFlavor(double intensity = 0)
    {
        Spicy = intensity;
    }
}