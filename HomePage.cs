using Elements;

namespace HomePage;

public class HomePageO : FieldsO
{
    Navigate navigate = new Navigate();
    public void OpenHomePage()
    {
        navigate.OpenPage("https://google.com", "Google");
    }

    static string HomeFieldXpath = "//*[@id='APjFqb']";
    public void SendTextHomeField(string text)
    {   SendTextField(HomeFieldXpath, text); }
    public void ClearHomeField()
    { ClearField(HomeFieldXpath); }

    public string? GetTextHomeField()
    { return GetTextInputBox(HomeFieldXpath); }
}
