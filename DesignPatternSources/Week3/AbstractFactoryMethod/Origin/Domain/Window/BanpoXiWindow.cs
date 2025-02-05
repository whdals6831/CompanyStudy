using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Domain.Window;

public class BanpoXiWindow : IWindow
{
    public BanpoXiWindow()
    {
        Console.WriteLine("반포자이 창 생성");
    }
}