using StrategyCase2.Good.Interface;

namespace StrategyCase2.Good.Domain;

public class Math : ISubject
{
    public string GetSubject()
    {
        return "수학";
    }
}