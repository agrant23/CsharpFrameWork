using Elements;
using HomePage;
using Driver;
using OpenQA.Selenium;

namespace HomePageTests;

public class Tests : IDisposable
{
    static DriverC driverO = new DriverC();
    static IWebDriver _driver = driverO.StartDriver();
    static NavigateC navigate = new NavigateC(_driver);
    static FieldsC fields = new FieldsC(_driver);
    public required HomePageC homePage = new HomePageC(navigate, fields, _driver);

    [OneTimeSetUp]
    public void Setup()
    {
        homePage.OpenHomePage();
    }

    [Test]
    public void Test1()
    {
        homePage.ClearHomeField();
        homePage.SendStringSearchBar("Yada something Foo Bar 45!");
        Assert.That(homePage.GetStringSearchBar(), Is.EqualTo("Yada something Foo Bar 45!"));
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
