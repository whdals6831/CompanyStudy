using StrategyCase2.Bad.Abstract;

namespace StrategyCase2.Bad.Domain;

public class EnglishScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("과학책을 읽습니다.");
    }

    public override void Translate()
    {
        Console.WriteLine("영어로 번역합니다.");
    }
}