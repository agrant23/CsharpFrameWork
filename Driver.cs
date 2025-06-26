using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Driver;

public class DriverO
{
    public IWebDriver StartDriver()
    {
        IWebDriver driver = new ChromeDriver("C:\\Repos\\MyTestFrameWork\\driver\\chromedriver-win32");
        return driver;
    }
}
