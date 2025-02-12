using StrategyCase1.Bad.Enum;

namespace StrategyCase1.Bad.Domain;

public class Navigation
{
    private NaviApp _naviApp;

    public void SetNaviApp(NaviApp app)
    {
        _naviApp = app;
    }

    // OCP 위배
    public void Start()
    {
        switch (_naviApp)
        {
            case NaviApp.Naver:
                Console.WriteLine("[ 네이버 지도 ]로 경로 안내를 시작합니다.");
                break;

            case NaviApp.Kakao:
                Console.WriteLine("[ 카카오 지도 ]로 경로 안내를 시작합니다.");
                break;

            case NaviApp.Google:
                Console.WriteLine("[ 구글 지도 ]로 경로 안내를 시작합니다.");
                break;
        }
    }
}