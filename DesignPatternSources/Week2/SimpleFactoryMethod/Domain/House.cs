using SimpleFactoryMethod.Interface;

namespace SimpleFactoryMethod.Domain;

public class House : IResidence
{
    public House()
    {
        Console.WriteLine("단독주택이 지어졌습니다.");
    }

    public void Enter()
    {
        Console.WriteLine("단독주택에 들어갔습니다.");
    }

    public void Leave()
    {
        Console.WriteLine("단독주택에서 나왔습니다.");
    }

    public void RingDoorBell()
    {
        Console.WriteLine("단독주택에서 초인종을 울렸습니다.");
    }
}