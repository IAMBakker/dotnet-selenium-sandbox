using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Test.firstTest
{

    [TestFixture]
    public class Tests : dotnet_selenium_sandbox.Test.Base.testbase
    {

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            
            Console.WriteLine(driver.Title);
            
            IWebElement query = driver.FindElement(By.Name("q"));
            
            query.SendKeys("Docker Selenium");
            query.Submit();
            Console.WriteLine(driver.Title);

            driver.Quit();
        }
    }
}