using Elements;
using HomePage;
using Driver;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace HomePageTests;

public class BaseTest : IDisposable
{
    //below must not be just a reference  "DriverO driverO;" since the class is required to load the driver in the setup method
    static DriverO driverO = new DriverO();
    static IWebDriver _driver = driverO.StartDriver();
    static NavigateO? navigate = new NavigateO(_driver);
    static FieldsO? fields = new FieldsO(_driver);
    public required HomePageO homePage = new HomePageO(navigate, fields, _driver);
    //static IWebDriver driver = driverO.StartDriver(); 

    [OneTimeSetUp]
    public void Setup()
    {
        // _driver = driverO.StartDriver();
        // NavigateO navigate = new NavigateO(_driver);
        // FieldsO fields = new FieldsO(_driver);
        // HomePageO homePage = new HomePageO(navigate, fields, _driver);
    //The below 3 lines are not ideal, I am in the middle of a solution for it
        //#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method

        //#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        homePage.OpenHomePage();
    }
    // private static readonly IWebDriver? driver;
    // private static NavigateO navigate = new NavigateO(driver);
    // private static FieldsO fields = new FieldsO(driver);
    // public HomePageO homePage = new HomePageO(navigate, fields);

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

[TestFixture]
public class Tests : BaseTest
{

    [Test]
    public void Test1()
    {
        homePage.ClearHomeField();
        homePage.SendTextSearchBar("Yada something Foo Bar");
        Assert.That(homePage.GetTextSearchBar(), Is.EqualTo("Yada something Foo Bar"));
    }
}
