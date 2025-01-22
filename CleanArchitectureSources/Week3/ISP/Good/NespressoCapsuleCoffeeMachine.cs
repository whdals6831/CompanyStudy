using ISP.Good;

public class NespressoCapsuleCoffeeMachine : ICoffeeMachine
{
    public void AddCoffee()
    {
        Console.WriteLine("콜롬비아맛 캡슐을 넣습니다.");
    }

    public void RemoveCoffee()
    {
        Console.WriteLine("캡슐을 제거합니다.");
    }

    public void WashMachine()
    {
        Console.WriteLine("머신을 청소합니다.");
    }
}