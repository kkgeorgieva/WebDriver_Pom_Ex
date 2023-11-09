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

        public void Open() 
        { 
            driver.Navigate().GoToUrl(PageUrl);
        }
        public bool isOpen()
        {
            return driver.Url == this.PageUrl;
        }
        public string GetPageUrl()
        { 
            return driver.Url;
        }






    }
}
