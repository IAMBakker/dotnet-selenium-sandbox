using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using dotnet_selenium_sandbox.Pages.Example;

namespace Test.FirstTest
{

    [TestFixture]
    public class Tests : dotnet_selenium_sandbox.Test.Base.TestBase
    {

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            
            Console.WriteLine(driver.Title);
            
            GoogleLandingPage google = new GoogleLandingPage(driver);
            google.queryGoogle("Page Objects In C#");
            
        }
    }
}