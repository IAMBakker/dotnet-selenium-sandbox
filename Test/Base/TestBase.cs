using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace dotnet_selenium_sandbox.Test.Base
{
    public class TestBase
    {
        protected RemoteWebDriver driver;
        protected RemoteLogs logs;

        [SetUp]
        public void SetUp(){
            ChromeOptions options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            driver = new RemoteWebDriver(options);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown(){
            var logs = driver.Manage().Logs.GetLog(LogType.Client);
            foreach(var log in logs){
                Console.Write(log);
            }
            driver.Quit();
        }
    }
}