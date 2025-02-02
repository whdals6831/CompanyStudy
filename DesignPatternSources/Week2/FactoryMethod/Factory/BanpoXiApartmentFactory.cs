using FactoryMethod.Domain;
using FactoryMethod.Interface;

namespace FactoryMethod.Factory;

public class BanpoXiApartmentFactory : ApartmentFactory
{
    protected override IApartment CreateApartment()
    {
        return new BanpoXi();
    }
}