using OpenQA.Selenium;
using Driver;

namespace Elements;

public class FieldsO : DriverO
{
    public void OpenPage(string PageURL)
    {
        //wait.Until(ExpectedConditions.TitleIs("Your Expected Title"));
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
        //for an Input box to get the "text" entered use the above not below
        //fieldElement.Text gets preexisting text from the UI
    }
}
