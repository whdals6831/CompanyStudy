using StrategyCase3.Domain;

public class Program
{
    private static void Main(string[] args)
    {
        var shoppinCart = new ShoppingCart();
        
        shoppinCart.AddItem(new Item("갤럭시s25", 1200000));
        shoppinCart.AddItem(new Item("삼다수", 3600));
        shoppinCart.AddItem(new Item("맥주", 9900));
        
        shoppinCart.Pay(new NaverPay("jjm9999@naver.com", "qwer1234!"));
        shoppinCart.Pay((new ShinhanCard("2873-8903-3378-1982", 772, "09/27")));
    }
}