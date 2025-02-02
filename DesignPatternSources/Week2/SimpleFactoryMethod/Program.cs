using SimpleFactoryMethod.Factory;

public class Program
{
    public static void Main()
    {
        var factory = new ApartmentFactory();
        
        var banpoXi = factory.Construct("BanpoXi");
        banpoXi.CreateElevator();
        banpoXi.CreateRoom();
        banpoXi.CreateWindow();
        
        var lotteCastle = factory.Construct("LotteCastle");
        lotteCastle.CreateElevator();
        lotteCastle.CreateRoom();
        lotteCastle.CreateWindow();
    }
}
