using System;
using OpenQA.Selenium;

namespace dotnet_selenium_sandbox.Pages.Example
{
    public class GoogleLandingPage : dotnet_selenium_sandbox.Pages.Base.WebPage
    {
        public GoogleLandingPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void queryGoogle(string text){
            IWebElement query = driver.FindElement(By.Name("q"));
            
            query.SendKeys(text);
            query.Submit();
            Console.WriteLine(driver.Title);

        }
    }
}