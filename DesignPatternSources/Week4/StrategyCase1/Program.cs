using StrategyCase1.Bad.Domain;
using StrategyCase1.Bad.Enum;
using StrategyCase1.Good.Domain;
using StrategyCase1.Good.Strategy;

public class Program
{
    private static void Main(string[] args)
    {
        // Bad
        var navigation = new Navigation();

        navigation.SetNaviApp(NaviApp.Naver);
        navigation.Start();

        navigation.SetNaviApp(NaviApp.Kakao);
        navigation.Start();
        
        // Good
        var navigationStrategy = new NavigationStrategy();
        
        navigationStrategy.SetNaviApp(new NaverMap());
        navigationStrategy.Start();
        
        navigationStrategy.SetNaviApp(new KakaoMap());
        navigationStrategy.Start();
    }
}