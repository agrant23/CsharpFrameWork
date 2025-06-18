using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Driver;

public abstract class DriverO
{
    internal IWebDriver Driver = new ChromeDriver("C:\\Repos\\MyTestFrameWork\\driver\\chromedriver-win32");
}
