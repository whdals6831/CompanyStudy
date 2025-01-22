using FactoryMethod.Factory;
using FactoryMethod.Interface;

public class Program
{
    public static void Main()
    {
        var apartFactory = new ApartmentFactory();
        var houseFactory = new HouseFactory();

        IResidence apartment = apartFactory.CreateResidence();
        apartment.RingDoorBell();
        apartment.Enter();
        apartment.Leave();
        
        IResidence house = houseFactory.CreateResidence();
        house.RingDoorBell();
        house.Enter();
        house.Leave();
    }
}