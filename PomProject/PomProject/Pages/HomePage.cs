using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
    }
}
