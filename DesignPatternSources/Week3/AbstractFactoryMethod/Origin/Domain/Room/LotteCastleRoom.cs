using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Domain.Room;

public class LotteCastleRoom : IRoom
{
    public LotteCastleRoom()
    {
        Console.WriteLine("롯데캐슬 방 생성");
    }
}