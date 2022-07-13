namespace GalacticThrone;

public class EncounterSelector
{
    public Encounter GetNextEncounter()
    {
        EncounterAction action1 = new EncounterAction("Do a thing", "You did it.");
        EncounterAction action2 = new EncounterAction("Do a different thing.", "you did something different.");
        EncounterAction[] actions = { action1, action2 };
        return new Encounter("This is the test encounter. Try to do stuff", actions);
    }
}