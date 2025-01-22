namespace DIP.Bad;

public class RollerCoaster
{
    private int _waitMinutes;
    private int _waitingVisitors;

    public void Run()
    {
        Console.WriteLine("롤러코스터가 출발합니다.");
        _waitMinutes = _waitingVisitors * 5 * 1000;
    }

    public void SetWaitingVisitors(int count)
    {
        _waitingVisitors = count;
    }

    public int GetWaitMinutes()
    {
        return _waitMinutes;
    }
}