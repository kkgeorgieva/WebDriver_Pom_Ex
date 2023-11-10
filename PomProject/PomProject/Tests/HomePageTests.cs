using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PomProject.Pages;
using System;

namespace PomProject.Tests
{
    public class HomePageTests : BaseTests
    {
       
       
        [Test]
        public void TestHomePage()
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
            //Arrange
            //Testing if the link opens up a new page with a different url
            var homePage = new HomePage(driver);
            //Act
            homePage.Open();

            homePage.abTesting.Click();

            var abTestingPage = new ABTestingPage(driver);
            //Assert
            Assert.That(abTestingPage.GetPageUrl, Is.EqualTo(driver.Url));

        }
        [Test]
        public void TestAddRemovePageOpen()
        {
            //Testing if the link opens up a new page with a different url
            var homePage = new HomePage(driver);
            homePage.Open();

            homePage.addRemoveElements.Click();

            var addRememove = new AddRemovePage(driver);

            Assert.That(addRememove.GetPageUrl, Is.EqualTo(driver.Url));

        }
        [Test]
        public void BasicAuthPageOpen()
        {
            //Testing if the link opens up a new page with a different url
            var homePage = new HomePage(driver);
            homePage.Open();

            homePage.basicAuth.Click();

            var basicAuth = new BasicAuthPage(driver);

            Assert.That(basicAuth.GetPageUrl, Is.EqualTo(driver.Url));

        }


    }
}
