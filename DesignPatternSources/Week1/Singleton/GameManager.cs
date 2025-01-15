namespace Singleton;

public class GameManager : Singleton<GameManager>
{
    public string GameState { get; private set; } = "Initializing";

    private GameManager() { }
    
    // 게임 상태를 변경하는 메서드
    public void ChangeGameState(string newState)
    {
        GameState = newState;
        Console.WriteLine($"Game state changed to: {GameState}");
    }
}