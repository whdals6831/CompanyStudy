namespace AbstractFactoryMethod.Origin.Factory;

public class ApartmentFactory
{
    public void Construct(string brend)
    {
        var elevatorFactory = new ElevatorFactory();
        var roomFactory = new RoomFactory();
        var windowFactory = new WindowFactory();
        
        elevatorFactory.CreateElevator(brend);
        roomFactory.CreateRoom(brend);
        windowFactory.CreateWindow(brend);

        Console.WriteLine($"{brend} 아파트 건축 완료");
    }
}

