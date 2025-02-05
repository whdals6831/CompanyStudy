using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Factory;

public class FactoryOfApartmentFactory
{
    public IApartmentFactory Construct(string brend)
    {
        IApartmentFactory factory;
        
        switch (brend)
        {
            case "BanpoXi":
                factory = new BanpoXiFactory();
                break;
            case "LotteCastle":
                factory = new LotteCastleFactory();
                break;
            default:
                throw new ArgumentException("제공하지 않는 브랜드입니다.");
        }

        factory.CreateElevator();
        factory.CreateRoom();
        factory.CreateWindow();

        Console.WriteLine($"{brend} 아파트 건축 완료");
        
        return factory;
    }
}

