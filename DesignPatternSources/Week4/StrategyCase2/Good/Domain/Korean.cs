using StrategyCase2.Good.Interface;

namespace StrategyCase2.Good.Domain;

public class Korean : ITranslate
{
    public void Translate()
    {
        Console.WriteLine("한글로 번역합니다.");
    }
}