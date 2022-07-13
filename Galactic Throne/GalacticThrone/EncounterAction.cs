namespace GalacticThrone;

public class EncounterAction
{
    public string ActionText { get; private set; }
    private string _executionText;
    
    public EncounterAction(string actionText, string executionText)
    {
        ActionText = actionText;
        _executionText = executionText;
    }

    public void ExecuteAction()
    {
        Screen.Print(_executionText);
    }
}