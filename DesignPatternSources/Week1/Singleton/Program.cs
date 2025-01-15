// See https://aka.ms/new-console-template for more information


using Singleton;

public class Program
{
    public static void Main()
    {
        var gameManager = GameManager.Instance;
        
        gameManager.ChangeGameState("Playing");
        gameManager.ChangeGameState("Paused");
    }
}
