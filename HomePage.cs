using Elements;

namespace HomePage;

public class HomePageO : FieldsO
{
    public void OpenHomePage()
    {
        //Navigate navigate = new Navigate();
        OpenPage("https://google.com", "Google");
    }

    static string HomeFieldXpath = "//*[@id='APjFqb']";
    public void SendTextSearchBar(string text)
    {   SendTextField(HomeFieldXpath, text); }
    public void ClearHomeField()
    { ClearField(HomeFieldXpath); }

    public string? GetTextSearchBar()
    { return GetTextInputBox(HomeFieldXpath); }
}
