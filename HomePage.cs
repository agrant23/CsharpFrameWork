using Elements;
using OpenQA.Selenium;

namespace HomePage;

public class HomePageC
{
    private readonly IWebDriver _driver;
    readonly NavigateC _navigate;
    readonly FieldsC _fields;

    public HomePageC(NavigateC navigate, FieldsC fields, IWebDriver driver)
    {
        this._driver = driver;
        this._navigate = navigate;
        this._fields = fields;
    }

    public void OpenHomePage()
    {
        _navigate.OpenPage("https://google.com", "Google");
    }

    static string HomeFieldXpath = "//*[@id='APjFqb']";
    
    public void SendStringSearchBar(string text)
    { _fields.SendStringField(HomeFieldXpath, text); }
    
    public void ClearHomeField()
    { _fields.ClearField(HomeFieldXpath); }

    public string? GetStringSearchBar()
    { return _fields.GetStringInputBox(HomeFieldXpath); }
}
