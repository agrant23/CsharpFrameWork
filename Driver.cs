using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Driver;

public class DriverC
{
    public IWebDriver StartDriver()
    {
        return new ChromeDriver("C:\\Repos\\MyTestFrameWork\\driver\\chromedriver-win32");
    }
}
