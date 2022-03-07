using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Tests
{
    public class Tests
    {
        public IWebDriver webDriver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            webDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.Pass();
        }
    }
}