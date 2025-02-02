using FactoryMethod.Domain;
using FactoryMethod.Interface;

namespace FactoryMethod.Factory;

public class LotteCastleApartmentFactory : ApartmentFactory
{
    protected override IApartment CreateApartment()
    {
        return new LotteCastle();
    }
}