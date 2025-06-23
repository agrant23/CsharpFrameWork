using Elements;

namespace HomePage;

public class HomePageO : FieldsO
{
    Navigate element = new Navigate();
    public void OpenHomePage()
    {
        element.OpenPage("https://google.com", "Google");
    }

    static string HomeFieldXpath = "//*[@id='APjFqb']";

    public void SendTextSearchBar(string text)
    { SendTextField(HomeFieldXpath, text); }

    public void ClearHomeField()
    { ClearField(HomeFieldXpath); }

    public string? GetTextSearchBar()
    { return GetTextInputBox(HomeFieldXpath); }

}
