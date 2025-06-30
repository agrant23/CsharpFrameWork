using Elements;
using OpenQA.Selenium;

namespace HomePage;

public class HomePageO
{
    readonly static IWebDriver? _driver;
    NavigateO _navigate = new NavigateO(_driver);
    FieldsO _fields = new FieldsO(_driver);

    public HomePageO(NavigateO navigate, FieldsO fields)
    {
        this._navigate = navigate;
        this._fields = fields;
    }

    public void OpenHomePage()
    {
        _navigate.OpenPage("https://google.com", "Google");
    }

    static string HomeFieldXpath = "//*[@id='APjFqb']";
    
    public void SendTextSearchBar(string text)
    { _fields.SendTextField(HomeFieldXpath, text); }
    
    public void ClearHomeField()
    { _fields.ClearField(HomeFieldXpath); }

    public string? GetTextSearchBar()
    { return _fields.GetTextInputBox(HomeFieldXpath); }
}
