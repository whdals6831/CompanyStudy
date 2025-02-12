using StrategyCase3.Interface;

namespace StrategyCase3.Domain;

public class ShinhanCard : IPayment
{
    private string _cardNumber;
    private int _cvv;
    private string _expirationDate;
    
    public ShinhanCard(string cardNumber, int cvv, string expirationDate)
    {
        _cardNumber = cardNumber;
        _cvv = cvv;
        _expirationDate = expirationDate;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"{amount}원이 신한 카드로 결제되었습니다.");
    }
}