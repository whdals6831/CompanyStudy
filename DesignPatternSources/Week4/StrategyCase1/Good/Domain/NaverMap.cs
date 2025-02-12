using StrategyCase1.Good.Interface;

namespace StrategyCase1.Good.Domain;

public class NaverMap : IMap
{
    public void Search()
    {
        Console.WriteLine("[ 네이버 지도 ]로 경로 안내를 시작합니다.");
    }
}