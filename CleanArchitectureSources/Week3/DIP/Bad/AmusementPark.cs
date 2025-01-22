namespace DIP.Bad;

public class AmusementPark
{
    private RollerCoaster _rollerCoaster;
    
    public AmusementPark(RollerCoaster rollerCoaster)
    {
        _rollerCoaster = rollerCoaster;
    }

    public int GetWaitMinutes()
    {
        return _rollerCoaster.GetWaitMinutes();
    }
}