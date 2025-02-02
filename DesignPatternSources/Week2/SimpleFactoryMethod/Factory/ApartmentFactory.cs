using SimpleFactoryMethod.Domain;
using SimpleFactoryMethod.Interface;

namespace SimpleFactoryMethod.Factory;

public class ApartmentFactory
{
    public IApartment Construct(string brendName)
    {
        IApartment apartment;

        switch (brendName)
        {
            case "BanpoXi":
                apartment = new BanpoXi();
                break;
            case "LotteCastle":
                apartment = new LotteCastle();
                break;
            default:
                throw new ArgumentException($"지원하지 않는 브랜드 입니다. => {brendName}");
        }
        
        apartment.Build();

        return apartment;
    }
}

