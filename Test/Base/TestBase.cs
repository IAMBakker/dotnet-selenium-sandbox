using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace dotnet_selenium_sandbox.Test.Base
{
    public class TestBase
    {
        protected IWebDriver driver;
        
        [SetUp]
        public void SetUp(){
            driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), new ChromeOptions());
        }

        [TearDown]
        public void TearDown(){
            driver.Quit();
        }
    }
}