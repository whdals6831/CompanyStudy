using AbstractFactoryMethod.Improved.Domain.Elevator;
using AbstractFactoryMethod.Improved.Domain.Room;
using AbstractFactoryMethod.Improved.Domain.Window;
using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Factory;

public class BanpoXiFactory : IApartmentFactory
{
    public IElevator CreateElevator()
    {
        return new BanpoXiElevator();
    }

    public IRoom CreateRoom()
    {
        return new BanpoXiRoom();
    }

    public IWindow CreateWindow()
    {
        return new BanpoXiWindow();
    }
}