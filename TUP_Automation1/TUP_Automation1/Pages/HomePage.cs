using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TUP_Automation1.Pages
{
    public class HomePage
    {
        public void NavigateToTimeMaterialPage(IWebDriver webDriver)
        {
            IWebElement admistrationdropdown = webDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admistrationdropdown.Click();
            IWebElement tmoption = webDriver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3]"));
            tmoption.Click();

        }
        //verify login user
        public void VerifyLoggedInUser(IWebDriver webDriver)
        {
            IWebElement LoginLink = webDriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (LoginLink.Text == "Hello hari!")
            {
                Console.WriteLine("user has logged in successfully");
            }
            else
            {
                Console.WriteLine("user has not been logged in");
            }
        }
    }
}
