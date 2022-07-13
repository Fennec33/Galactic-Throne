namespace GalacticThroneTests;
using GalacticThrone;

public class EmpireTests
{
    [Test]
    public void Test1()
    {
        Empire empire = new Empire();
        empire.AddCredits(10);
        Assert.That(empire.Credits, Is.EqualTo(60));
    }
}