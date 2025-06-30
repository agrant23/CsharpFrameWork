using Elements;
using HomePage;
using Driver;
using OpenQA.Selenium;

namespace HomePageTests;

public class Tests : IDisposable
{
    static DriverO driverO = new DriverO();
    static IWebDriver _driver = driverO.StartDriver();
    static NavigateO navigate = new NavigateO(_driver);
    static FieldsO fields = new FieldsO(_driver);
    public required HomePageO homePage = new HomePageO(navigate, fields, _driver);

    [OneTimeSetUp]
    public void Setup()
    {
        homePage.OpenHomePage();
    }

    [Test]
    public void Test1()
    {
        homePage.ClearHomeField();
        homePage.SendStringSearchBar("Yada something Foo Bar");
        Assert.That(homePage.GetStringSearchBar(), Is.EqualTo("Yada something Foo Bar"));
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _driver.Quit();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
