using StrategyCase2.Bad.Domain;
using StrategyCase2.Good.Domain;
using Math = StrategyCase2.Good.Domain.Math;

public class Program
{
    private static void Main(string[] args)
    {
        // Bad
        var koreanMathBook = new KoreanMathBook();
        var koreanScienceBook = new KoreanScienceBook();
        var englishMathBook = new EnglishMathBook();
        var englishScienceBook = new EnglishScienceBook();
        
        koreanMathBook.Translate();
        koreanMathBook.Read();
        koreanScienceBook.Translate();
        koreanScienceBook.Read();
        englishMathBook.Translate();
        englishMathBook.Read();
        englishScienceBook.Translate();
        englishScienceBook.Read();
        
        // Good
        var book = new Book(new Math(), new Korean());
        book.Translate();
        book.Read();

        book.SetSubject(new Science());
        book.SetTranslate(new English());
        book.Translate();
        book.Read();
        
    }
}