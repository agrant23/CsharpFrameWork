using Elements;

namespace HomePage;

public class HomePageO : FieldsO
{
    //static FieldsO field = new FieldsO();
    public void OpenHomePage()
    {
        OpenPage("https://google.com");
    }

    public void SendTextHomeField() //string text)
    {
        string HomeFieldXpath = "//*[@id='APjFqb']";
        SendTextField(HomeFieldXpath, "Yada Foo Bar");
    }
    public void ClearHomeField()
    {
        string HomeFieldXpath = "//*[@id='APjFqb']";
        ClearField(HomeFieldXpath);
    }

}
