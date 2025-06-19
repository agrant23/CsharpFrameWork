using OpenQA.Selenium;
using Driver;

namespace Elements;

public class FieldsO : DriverO
{
    public void OpenPage(string PageURL)
    {
        Driver.Navigate().GoToUrl(PageURL);
    }
    public void SendTextField(string Xpath, string text)
    {
        IWebElement fieldElement = Driver.FindElement(By.XPath(Xpath));
        fieldElement.SendKeys(text);
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
    }
    public void ClearField(string Xpath)
    {
        IWebElement fieldElement = Driver.FindElement(By.XPath(Xpath));
        fieldElement.Clear();
    }
    public string GetText(string Xpath)
    {
        IWebElement fieldElement = Driver.FindElement(By.XPath(Xpath));
        return fieldElement.Text;
    }
}
