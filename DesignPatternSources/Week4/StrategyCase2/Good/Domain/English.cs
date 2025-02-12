using StrategyCase2.Good.Interface;

namespace StrategyCase2.Good.Domain;

public class English : ITranslate
{
    public void Translate()
    {
        Console.WriteLine("영어로 번역합니다.");
    }
}