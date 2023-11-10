using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomProject.Tests
{
    //Base class for SetUp and TearDown attributes
    public class BaseTests
    {
        //Instantiate
        public  IWebDriver driver;
        
        [OneTimeSetUp]
        public void SetUp() 
        {
            //Initialize
            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // Set a delay of 5 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [OneTimeTearDown]
        public void ShutDownBrowser()
        {
            driver.Quit();
        }

    }
}
