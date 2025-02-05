using AbstractFactoryMethod.Origin.Domain.Window;
using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Factory;

public class WindowFactory
{
    public IWindow CreateWindow(string brend)
    {
        IWindow window;

        switch (brend)
        {
            case "BanpoXi":
                window = new BanpoXiWindow();
                break;
            case "LotteCastle":
                window = new LotteCastleWindow();
                break;
            default:
                throw new ArgumentException("제공하지 않는 브랜드입니다.");
        }
    
        return window;
    }
}