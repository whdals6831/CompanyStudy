using FactoryMethod.Domain;
using FactoryMethod.Interface;

namespace FactoryMethod.Factory;

public class HouseFactory : IResidenceFactory
{
    public IResidence CreateResidence()
    {
        return new House();
    }
}