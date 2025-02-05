using AbstractFactoryMethod.Origin.Domain.Elevator;
using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Factory;

public class ElevatorFactory
{
    public IElevator CreateElevator(string brend)
    {
        IElevator elevator;

        switch (brend)
        {
            case "BanpoXi":
                elevator = new BanpoXiElevator();
                break;
            case "LotteCastle":
                elevator = new LotteCastleElevator();
                break;
            default:
                throw new ArgumentException("제공하지 않는 브랜드입니다.");
        }
        
        return elevator;
    }
}