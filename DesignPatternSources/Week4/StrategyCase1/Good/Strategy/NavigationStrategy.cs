using StrategyCase1.Good.Interface;

namespace StrategyCase1.Good.Strategy;

public class NavigationStrategy
{
    private IMap _app;
    
    public void SetNaviApp(IMap app)
    {
        _app = app;
    }

    public void Start()
    {
        _app.Search();
    }
}