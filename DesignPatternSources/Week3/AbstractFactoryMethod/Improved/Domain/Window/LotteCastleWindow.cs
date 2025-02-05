using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Domain.Window;

public class LotteCastleWindow : IWindow
{
    public LotteCastleWindow()
    {
        Console.WriteLine("롯데캐슬 창 생성");
    }
}