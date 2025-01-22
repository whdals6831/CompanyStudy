namespace ISP.Bad;

public class KanuCoffeeMachine : ICoffeeMachine
{
    public void AddCoffee()
    {
        Console.WriteLine("케냐AA 원두를 넣었습니다.");
    }

    public void GrindCoffee()
    {
        Console.WriteLine("추가한 커피를 곱게 갈아버립니다.");
    }

    public void RemoveCoffee()
    {
        Console.WriteLine("커피 찌꺼기를 제거합니다.");
    }

    public void WashMachine()
    {
        Console.WriteLine("커피 머신을 청소합니다.");
    }
}