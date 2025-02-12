using StrategyCase1.Good.Interface;

namespace StrategyCase1.Good.Domain;

public class GoogleMap : IMap
{
    public void Search()
    {
        Console.WriteLine("[ 구글 지도 ]로 경로 안내를 시작합니다.");
    }
}