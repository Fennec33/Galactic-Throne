namespace GalacticThrone;

public class Empire
{
    public int Credits { get; private set; }
    public int Population { get; private set;}
    public int Military { get; private set;}
    public int Science { get; private set;}

    public Empire()
    {
        Credits = 50;
        Population = 50;
        Military = 50;
        Science = 50;
    }

    public void AddCredits(int n)
    {
        n += Credits;
        if (n is > 0 and < 100)
            Credits = n;
    }

    public void PrintResources()
    {
        Screen.Print("Credits: " + Credits);
        Screen.Print("Population: " + Population);
        Screen.Print("Military: " + Military);
        Screen.Print("Science: " + Science);
        Screen.PrintBlankLine();
    }
}