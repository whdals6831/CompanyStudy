using SimpleFactoryMethod.Enum;
using SimpleFactoryMethod.Factory;
using SimpleFactoryMethod.Interface;

public class Program
{
    public static void Main()
    {
        var factory = new SimpleResidenceFactory();
        
        IResidence apartment = factory.CreateResidence(ResidenceType.Apartment);
        apartment.RingDoorBell();
        apartment.Enter();
        apartment.Leave();
        
        IResidence house = factory.CreateResidence(ResidenceType.House);
        house.RingDoorBell();
        house.Enter();
        house.Leave();
    }
}
