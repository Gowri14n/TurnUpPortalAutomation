using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TUP_Automation1.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver webDriver)
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
            IWebElement usernameTextbox = webDriver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            IWebElement passwordTextbox = webDriver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
        }

    }
}
