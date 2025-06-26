using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Driver;

namespace Elements;

public class NavigateO
{
    IWebDriver _driver;

    public NavigateO(IWebDriver driver)
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
public class FieldsO
{
    IWebDriver _driver;

    public FieldsO(IWebDriver driver)
    {
        this._driver = driver;
    }

    public void SendTextField(string Xpath, string text)
    {
        IWebElement fieldElement = _driver.FindElement(By.XPath(Xpath));
        fieldElement.SendKeys(text);
    }

    public void ClearField(string Xpath)
    {
        IWebElement fieldElement = _driver.FindElement(By.XPath(Xpath));
        fieldElement.Clear();
    }

    public string? GetTextInputBox(string Xpath)
    {
        IWebElement fieldElement = _driver.FindElement(By.XPath(Xpath));
        return fieldElement.GetAttribute("value");
    }
}
