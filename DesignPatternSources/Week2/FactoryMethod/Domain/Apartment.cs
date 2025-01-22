using FactoryMethod.Interface;

namespace FactoryMethod.Domain;

public class Apartment : IResidence
{
    public Apartment()
    {
        Console.WriteLine("아파트가 지어졌습니다.");
    }

    public void Enter()
    {
        Console.WriteLine("아파트에 들어갔습니다.");
    }

    public void Leave()
    {
        Console.WriteLine("아파트에서 나왔습니다.");
    }

    public void RingDoorBell()
    {
        Console.WriteLine("아파트 현관에서 세대를 호출했습니다.");
    }
}