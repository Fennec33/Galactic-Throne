namespace GalacticThrone;

public class EmpireResources
{
    private int _credits;
    private int _population;
    private int _military;
    private int _science;

    public int Credits
    {
        get => _credits;
        set
        {
            if (value is > 0 and < 100)
                _credits = value;
        }
    }
    
    public int Population
    {
        get => _population;
        set
        {
            if (value is > 0 and < 100)
                _population = value;
        }
    }
    
    public int Military
    {
        get => _military;
        set
        {
            if (value is > 0 and < 100)
                _military = value;
        }
    }
    
    public int Science
    {
        get => _science;
        set
        {
            if (value is > 0 and < 100)
                _science = value;
        }
    }

    public EmpireResources()
    {
        _credits = 50;
        _population = 50;
        _military = 50;
        _science = 50;
    }

    public void PrintResources()
    {
        Console.WriteLine("Credits: " + _credits);
        Console.WriteLine("Population: " + _population);
        Console.WriteLine("Military: " + _military);
        Console.WriteLine("Science: " + _science);
        GameManager.PrintBlankLine();
    }
}