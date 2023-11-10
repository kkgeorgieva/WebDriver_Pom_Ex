using OpenQA.Selenium;
using PomProject.Pages;

namespace PomProject.Tests
{
   public class ABTestingTests : BaseTests
    {
        //Fidnd the paragraph and assert it is not empty
        [Test]
        public void paragraphTest()
        { 
            var abtestpage = new ABTestingPage(driver);
            abtestpage.Open();

            Assert.NotNull(driver.FindElement(By.CssSelector("#content > div > p")));
        }
    }
}
