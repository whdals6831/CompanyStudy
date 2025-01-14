namespace SRP.Good;

public class Ramen : Food, ITasteManager
{
    public string Noodle { get; set; } = "flour";
    
    public void SetSpicyFlavor(double intensity)
    {
        Spicy = intensity;
    }
}