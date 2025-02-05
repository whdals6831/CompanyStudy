namespace AbstractFactoryMethod.Improved.Interface;

public interface IApartmentFactory
{
    IElevator CreateElevator();
    IRoom CreateRoom();
    IWindow CreateWindow();
}