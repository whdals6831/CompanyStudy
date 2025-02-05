using AbstractFactoryMethod.Improved.Domain.Elevator;
using AbstractFactoryMethod.Improved.Domain.Room;
using AbstractFactoryMethod.Improved.Domain.Window;
using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Factory;

public class LotteCastleFactory : IApartmentFactory
{
    public IElevator CreateElevator()
    {
        return new LotteCastleElevator();
    }

    public IRoom CreateRoom()
    {
        return new LotteCastleRoom();
    }

    public IWindow CreateWindow()
    {
        return new LotteCastleWindow();
    }
}