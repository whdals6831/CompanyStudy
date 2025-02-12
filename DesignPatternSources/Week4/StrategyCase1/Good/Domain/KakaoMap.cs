using StrategyCase1.Good.Interface;

namespace StrategyCase1.Good.Domain;

public class KakaoMap : IMap
{
    public void Search()
    {
        Console.WriteLine("[ 카카오 지도 ]로 경로 안내를 시작합니다.");
    }
}