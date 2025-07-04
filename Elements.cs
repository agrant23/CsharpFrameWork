using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Elements;

public class NavigateC
{
    IWebDriver _driver;

    public NavigateC(IWebDriver driver)
    {
        this._driver = driver;
    }
    public void OpenPage(string pageURL, string pageTitle)
    {
        _driver.Navigate().GoToUrl(pageURL);
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.TitleIs(pageTitle));
    }
}
public class FieldsC
{
    IWebDriver _driver;

    public FieldsC(IWebDriver driver)
    {
        this._driver = driver;
    }

    public void SendStringField(string Xpath, string text)
    {
        IWebElement fieldElement = _driver.FindElement(By.XPath(Xpath));
        fieldElement.SendKeys(text);
    }

    public void ClearField(string Xpath)
    {
        IWebElement fieldElement = _driver.FindElement(By.XPath(Xpath));
        fieldElement.Clear();
    }

    public string? GetStringInputBox(string Xpath)
    {
        IWebElement fieldElement = _driver.FindElement(By.XPath(Xpath));
        return fieldElement.GetAttribute("value");
    }
}
