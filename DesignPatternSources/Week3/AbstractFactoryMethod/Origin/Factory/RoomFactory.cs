using AbstractFactoryMethod.Origin.Domain.Room;
using AbstractFactoryMethod.Origin.Interface;

namespace AbstractFactoryMethod.Origin.Factory;

public class RoomFactory
{
    public IRoom CreateRoom(string brend)
    {
        IRoom room;

        switch (brend)
        {
            case "BanpoXi":
                room = new BanpoXiRoom();
                break;
            case "LotteCastle":
                room = new LotteCastleRoom();
                break;
            default:
                throw new ArgumentException("제공하지 않는 브랜드입니다.");
        }
    
        return room;
    }
}