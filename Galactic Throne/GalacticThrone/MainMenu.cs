namespace GalacticThrone;

public class MainMenu : IInputHandler
{
    public void HandleInput(string input)
    {
        switch (input)
        {
            case "start":
                StartGame();
                break;
            default:
                Screen.PrintInputError();
                break;
        }
    }

    public void Open()
    {
        Screen.Clear();
        ImagePrinter.Title();
        Screen.Print("Welcome to the game.");
        Screen.PrintBlankLine();
        GameManager.PlayerEmpire.PrintResources();
    }

    private void StartGame()
    {
        GameManager.GoToEncounter();
    }
}