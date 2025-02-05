using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Domain.Room;

public class BanpoXiRoom : IRoom
{
    public BanpoXiRoom()
    {
        Console.WriteLine("반포자이 방 생성");
    }
}