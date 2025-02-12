using StrategyCase2.Good.Interface;

namespace StrategyCase2.Good.Domain;

public class Science : ISubject
{
    public string GetSubject()
    {
        return "과학";
    }
}