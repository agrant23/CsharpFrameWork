using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Driver;

namespace Elements;

public class FieldsO : DriverO
{
    public void OpenPage(string pageURL, string pageTitle)
    {
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.TitleIs(pageTitle));
        Driver.Navigate().GoToUrl(pageURL);
    }
    
    public void SendTextField(string Xpath, string text)
    {
        IWebElement fieldElement = Driver.FindElement(By.XPath(Xpath));
        fieldElement.SendKeys(text);
    }

    public void ClearField(string Xpath)
    {
        IWebElement fieldElement = Driver.FindElement(By.XPath(Xpath));
        fieldElement.Clear();
    }

    public string? GetTextInputBox(string Xpath)
    {
        IWebElement fieldElement = Driver.FindElement(By.XPath(Xpath));
        return fieldElement.GetAttribute("value");
    }
}
