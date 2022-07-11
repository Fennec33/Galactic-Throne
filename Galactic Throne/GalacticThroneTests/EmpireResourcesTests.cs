namespace GalacticThroneTests;
using GalacticThrone;

public class EmpireResourcesTests
{
    [Test]
    public void Test1()
    {
        EmpireResources empire = new EmpireResources();
        empire.AddCredits(10);
        Assert.That(empire.Credits, Is.EqualTo(60));
    }
}