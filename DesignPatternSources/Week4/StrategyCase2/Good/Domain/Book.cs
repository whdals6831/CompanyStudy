using StrategyCase2.Good.Interface;

namespace StrategyCase2.Good.Domain;

public class Book
{
    private ISubject _subject;
    private ITranslate _translate;

    public Book(ISubject subject, ITranslate translate)
    {
        _subject = subject;
        _translate = translate;
    }
    
    public void SetSubject(ISubject subject) => _subject = subject;
    
    public void SetTranslate(ITranslate translate) => _translate = translate;

    public void Read()
    {
        Console.WriteLine($"{_subject.GetSubject()}책을 읽습니다.");
    }

    public void Translate()
    {
        _translate.Translate();
    }
}