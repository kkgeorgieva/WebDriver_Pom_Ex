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
        [TearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
        [Test]
        public void TestHomePageLinks()
        { 
            var homePage = new HomePage(driver);
            homePage.Open();
            
            Assert.That(driver.Url, Is.EqualTo(homePage.GetPageUrl()));
            //Assert that the home page heading is equal to the homepage's headings' css selector
            
            Assert.That(homePage.HomePageHeading, Is.EqualTo(homePage.pageHeding.Text));
            Assert.That(homePage.GetPageTitle,Is.EqualTo("The Internet"));
        }
        [Test]
        public void TestABTesingPageOpen()
        {
            //Testing if the link opens up a new page with a different url
            var homePage = new HomePage(driver);
            homePage.Open();

            homePage.abTesting.Click();

            var abTestingPage = new ABTestingPage(driver);

            Assert.That(abTestingPage.GetPageUrl, Is.EqualTo(driver.Url));

        }

    }
}
