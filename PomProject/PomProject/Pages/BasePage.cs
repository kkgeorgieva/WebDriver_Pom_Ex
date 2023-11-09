using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomProject.Pages
{
    // Creating the base page
    public class BasePage
    {

        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }
        //Creating a constructor
        public BasePage(IWebDriver driver) 
        { 
            this.driver = driver;
        }
        //Finding page heading 
        public IWebElement pageHeding => driver.FindElement(By.CssSelector("#content > h1"));

        //Finding 4 different links on the homepage

        public IWebElement abTesting => driver.FindElement(By.LinkText("A/B Testing"));
        public IWebElement addRemoveElements => driver.FindElement(By.LinkText("Add/Remove Elements"));
        public IWebElement basicAuth => driver.FindElement(By.LinkText("Basic Auth"));
        public IWebElement brokenImg => driver.FindElement(By.LinkText("Broken Images"));




    }
}
