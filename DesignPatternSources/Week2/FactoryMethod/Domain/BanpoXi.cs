using FactoryMethod.Interface;

namespace FactoryMethod.Domain;

public class BanpoXi : IApartment
{
    public void Build()
    {
        Console.WriteLine("반포자이 아파트가 만들어졌습니다.");
    }
    
    public void CreateElevator()
    {
        Console.WriteLine("초고속 엘레베이터를 만듭니다.");
    }

    public void CreateRoom()
    {
        Console.WriteLine("91평짜리 방을 만듭니다.");
    }

    public void CreateWindow()
    {
        Console.WriteLine("밖에서는 안보이는 고급진 창을 만듭니다.");
    }
}