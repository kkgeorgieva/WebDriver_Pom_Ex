using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomProject.Pages
{
    public class AddRemovePage : BasePage
    {
        private IWebDriver driver;

        // Constructor to initialize the driver
        public AddRemovePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        //Overriding the PageUrl parameter
        public override string PageUrl => "https://the-internet.herokuapp.com/add_remove_elements/";
        public IWebElement pageHeding => driver.FindElement(By.CssSelector("#content > h3"));


    }
}
 