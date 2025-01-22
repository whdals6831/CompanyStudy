using FactoryMethod.Domain;
using FactoryMethod.Interface;

namespace FactoryMethod.Factory;

public class ApartmentFactory : IResidenceFactory
{
    public IResidence CreateResidence()
    {
        return new Apartment();
    }
}