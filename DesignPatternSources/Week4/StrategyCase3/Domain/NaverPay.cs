using StrategyCase3.Interface;

namespace StrategyCase3.Domain;

public class NaverPay : IPayment
{
    private string _email;
    private string _password;
    
    public NaverPay(string email, string password)
    {
        _email = email;
        _password = password;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"{amount}원이 네이버 페이로 결제되었습니다.");
    }
}