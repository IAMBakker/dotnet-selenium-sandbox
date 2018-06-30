using OpenQA.Selenium;

namespace dotnet_selenium_sandbox.Pages.Base
{
    public class WebPage
    {
        protected IWebDriver driver;
        public WebPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}