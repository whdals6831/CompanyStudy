namespace DIP.Good;

public class AmusementPark
{
    private IRide _ride;
    
    public AmusementPark(IRide ride)
    {
        _ride = ride;
    }

    public int GetWaitMinutes()
    {
        return _ride.GetWaitMinutes();
    }
}