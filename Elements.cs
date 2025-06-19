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
