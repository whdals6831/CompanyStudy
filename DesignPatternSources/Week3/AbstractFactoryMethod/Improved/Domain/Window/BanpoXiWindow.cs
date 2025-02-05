using AbstractFactoryMethod.Improved.Interface;

namespace AbstractFactoryMethod.Improved.Domain.Window;

public class BanpoXiWindow : IWindow
{
    public BanpoXiWindow()
    {
        Console.WriteLine("반포자이 창 생성");
    }
}