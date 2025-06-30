using Elements;
using OpenQA.Selenium;

namespace HomePage;

public class HomePageO
{
    private readonly IWebDriver _driver;
    readonly NavigateO _navigate;
    readonly FieldsO _fields;

    public HomePageO(NavigateO navigate, FieldsO fields, IWebDriver driver)
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
