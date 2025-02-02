using FactoryMethod.Factory;
using FactoryMethod.Interface;

public class Program
{
    public static void Main()
    {
        var banpoXiFactory = new BanpoXiApartmentFactory();
        var lotteCastleFactory = new LotteCastleApartmentFactory();

        IApartment banpoXi = banpoXiFactory.Construct();
        banpoXi.CreateElevator();
        banpoXi.CreateRoom();
        banpoXi.CreateWindow();

        IApartment lotteCastle = lotteCastleFactory.Construct();
        lotteCastle.CreateElevator();
        lotteCastle.CreateRoom();
        lotteCastle.CreateWindow();
    }
}