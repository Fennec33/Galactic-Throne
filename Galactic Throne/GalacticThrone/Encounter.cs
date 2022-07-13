namespace GalacticThrone;

public class Encounter : IInputHandler
{
    private string _mainText;
    private EncounterAction _action1;
    private EncounterAction _action2;
    
    public Encounter(String mainText, EncounterAction[] actions)
    {
        _mainText = mainText;
        _action1 = actions[0];
        _action2 = actions[1];
    }
    
    public void HandleInput(string input)
    {
        switch (input)
        {
            case "1":
                _action1.ExecuteAction();
                break;
            case "2":
                _action2.ExecuteAction();
                break;
            default:
                Screen.PrintInputError();
                break;
        }
    }

    public void Open()
    {
        Screen.Clear();
        Screen.Print(_mainText);
        Screen.PrintBlankLine();
        Screen.Print("1) " + _action1.ActionText);
        Screen.Print("2) " + _action2.ActionText);
        Screen.PrintBlankLine();
    }
}