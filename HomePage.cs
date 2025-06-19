using Elements;

namespace HomePage;

public class HomePageO : FieldsO
{
    public void OpenHomePage()
    {
        OpenPage("https://google.com");
    }

    static string HomeFieldXpath = "//*[@id='APjFqb']";
    public void SendTextHomeField(string text)
    {   SendTextField(HomeFieldXpath, text); }
    public void ClearHomeField()
    { ClearField(HomeFieldXpath); }

    public string GetTextHomeField()
    { return GetTextInputBox(HomeFieldXpath); }
}
