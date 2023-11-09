using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PomProject.Pages;
using System;

namespace PomProject.Tests
{
    public class HomePageTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // Initialize the driver
            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // Set a delay of 5 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void TestHomePageLinks()
        { 
            var homePage = new HomePage(driver);
            homePage.Open();
            Assert.That(driver.Url, Is.EqualTo(homePage.GetPageUrl()));
        }
    }
}
