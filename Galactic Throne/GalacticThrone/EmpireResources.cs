namespace GalacticThrone;

public class EmpireResources
{
    public int Credits { get; private set; }

    public int Population { get; private set;}

    public int Military { get; private set;}

    public int Science { get; private set;}

    public EmpireResources()
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
        Console.WriteLine("Credits: " + Credits);
        Console.WriteLine("Population: " + Population);
        Console.WriteLine("Military: " + Military);
        Console.WriteLine("Science: " + Science);
        GameManager.PrintBlankLine();
    }
}