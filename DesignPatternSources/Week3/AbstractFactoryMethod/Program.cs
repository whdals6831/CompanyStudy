using AbstractFactoryMethod.Improved.Factory;
using AbstractFactoryMethod.Origin.Factory;

public class Program
{
    public static void Main()
    {
        // Origin
        var factory = new ApartmentFactory();
        
        factory.Construct("BanpoXi");
        factory.Construct("LotteCastle");
        
        // Improved
        var abstractFactory = new FactoryOfApartmentFactory();
        
        abstractFactory.Construct("BanpoXi");
        abstractFactory.Construct("LotteCastle");
    }
}