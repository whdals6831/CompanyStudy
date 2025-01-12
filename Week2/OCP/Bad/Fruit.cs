namespace OCP.Bad;

public class Fruit
{
    private string _name;

    public Fruit(string name)
    {
        _name = name;
    }

    public string GetName() => _name;
}