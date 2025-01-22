using System.ComponentModel;
using SimpleFactoryMethod.Domain;
using SimpleFactoryMethod.Enum;
using SimpleFactoryMethod.Interface;

namespace SimpleFactoryMethod.Factory;

public class SimpleResidenceFactory
{
    public IResidence CreateResidence(ResidenceType type) => type switch
    {
        ResidenceType.Apartment => new Apartment(),
        ResidenceType.House => new House(),
        _ => throw new InvalidEnumArgumentException()
    };
}