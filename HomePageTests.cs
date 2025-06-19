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
        SendTextSearchBar("Yada something Foo Bar");
        Assert.That(GetTextSearchBar(), Is.EqualTo("Yada something Foo Bar"));
    }

    [TearDown]
    public void closeBrowser()
    {
        Driver.Quit();
    }
}
