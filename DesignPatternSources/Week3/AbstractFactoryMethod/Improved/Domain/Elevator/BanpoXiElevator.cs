using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Domain.Elevator;

public class BanpoXiElevator : IElevator
{
    public BanpoXiElevator()
    {
        Console.WriteLine("반포자이 엘레베이터 생성");
    }
}