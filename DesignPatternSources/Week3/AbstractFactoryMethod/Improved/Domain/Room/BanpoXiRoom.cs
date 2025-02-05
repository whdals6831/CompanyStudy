using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Domain.Room;

public class BanpoXiRoom : IRoom
{
    public BanpoXiRoom()
    {
        Console.WriteLine("반포자이 방 생성");
    }
}