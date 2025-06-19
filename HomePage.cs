using Elements;

namespace HomePage;

public class HomePageO : FieldsO
{
    public void OpenHomePage()
    {
        OpenPage("https://google.com");
    }

    static string HomeSearchBarXpath = "//*[@id='APjFqb']";
    
    public void SendTextSearchBar(string text)
    { SendTextField(HomeSearchBarXpath, text); }
    public void ClearSearchBar()
    { ClearField(HomeSearchBarXpath); }

    public string GetTextSearchBar()
    { return GetTextInputBox(HomeSearchBarXpath); }
}
