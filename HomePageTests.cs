using HomePage;

namespace HomePageTests;

public class Tests : HomePageO
{
    [SetUp]
    public void Setup()
    {
        OpenHomePage();
    }

    [Test]
    public void Test1()
    {
        SendTextHomeField();
        ClearHomeField();
        Assert.Pass();
    }

    [TearDown]
    public void closeBrowser()
    {
        Driver.Quit();
    }
}
