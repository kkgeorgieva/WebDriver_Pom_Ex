using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomProject.Pages
{
    public class ABTestingPage : BasePage
    {
        private IWebDriver driver;

        // Constructor to initialize the driver
        public ABTestingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        //Overriding the PageUrl parameter
        public override string PageUrl => "https://the-internet.herokuapp.com/abtest";
        public IWebElement pageHeding => driver.FindElement(By.CssSelector("#content > div > h3"));
        public IWebElement paragraph => driver.FindElement(By.CssSelector("#content > div > p"));


    }
}
 