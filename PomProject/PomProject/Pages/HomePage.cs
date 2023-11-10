using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            //empty constructor
        }

        //Overriding the PageUrl parameter
        public override string PageUrl => "https://the-internet.herokuapp.com/";


        //Finding page heading 
        public IWebElement pageHeding => driver.FindElement(By.CssSelector("#content > h1"));
        public IWebElement secondHeading => driver.FindElement(By.CssSelector("#content > h2"));

        //Finding 4 different links on the homepage

        public IWebElement abTesting => driver.FindElement(By.LinkText("A/B Testing"));
        public IWebElement addRemoveElements => driver.FindElement(By.LinkText("Add/Remove Elements"));
        public IWebElement basicAuth => driver.FindElement(By.LinkText("Basic Auth"));
        public IWebElement brokenImg => driver.FindElement(By.LinkText("Broken Images"));

        public String HomePageHeading() 
        { 
        return this.pageHeding.Text;
        }
    }

}
