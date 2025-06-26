using Elements;
using HomePage;
using Driver;
using OpenQA.Selenium;

namespace HomePageTests;

public class Tests
{
    static DriverO driverO = new DriverO();

    //The below 3 lines are not ideal, I am in the middle of a solution for it
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
    private static readonly IWebDriver driver = driverO.StartDriver();
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
    static NavigateO navigate = new NavigateO(driver);
    static FieldsO fields = new FieldsO(driver);
    HomePageO homePage = new HomePageO(navigate, fields);

    [SetUp]
    public void Setup()
    {
        homePage.OpenHomePage();
    }

    [Test]
    public void Test1()
    {
        homePage.ClearHomeField();
        homePage.SendTextSearchBar("Yada something Foo Bar");
        Assert.That(homePage.GetTextSearchBar(), Is.EqualTo("Yada something Foo Bar"));
    }

    [TearDown]
    public void closeBrowser()
    {
        driver.Quit();
    }
}
