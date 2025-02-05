using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Domain.Elevator;

public class LotteCastleElevator : IElevator
{
    public LotteCastleElevator()
    {
        Console.WriteLine("롯데캐슬 엘레베이터 생성");
    }
}