using FactoryMethod.Interface;

namespace FactoryMethod.Factory;

public abstract class ApartmentFactory
{
    public IApartment Construct()
    {
        IApartment apartment = CreateApartment();
        apartment.Build();

        return apartment;
    }

    protected abstract IApartment CreateApartment();
}

