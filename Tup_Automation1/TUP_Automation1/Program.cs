using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver webDriver = new ChromeDriver();
webDriver.Manage().Window.Maximize();
webDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
IWebElement usernameTextbox = webDriver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
IWebElement passwordTextbox = webDriver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();
IWebElement LoginLink = webDriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
if(LoginLink.Text == "Hello hari!")
{
    Console.WriteLine("user has logged in successfully");
}
else
{
    Console.WriteLine("user has not been logged in");
}