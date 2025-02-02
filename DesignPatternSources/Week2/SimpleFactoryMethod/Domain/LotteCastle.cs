using SimpleFactoryMethod.Interface;

namespace SimpleFactoryMethod.Domain;

public class LotteCastle : IApartment
{
    public void Build()
    {
        Console.WriteLine("롯데캐슬 아파트가 만들어졌습니다.");
    }
    
    public void CreateElevator()
    {
        Console.WriteLine("고속 엘레베이터를 만듭니다.");
    }

    public void CreateRoom()
    {
        Console.WriteLine("72평짜리 방을 만듭니다.");
    }

    public void CreateWindow()
    {
        Console.WriteLine("튼튼한 창을 만듭니다.");
    }
}