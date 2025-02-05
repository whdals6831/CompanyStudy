using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Domain.Window;

public class LotteCastleWindow : IWindow
{
    public LotteCastleWindow()
    {
        Console.WriteLine("롯데캐슬 창 생성");
    }
}