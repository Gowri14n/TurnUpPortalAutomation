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
IWebElement admistrationdropdown = webDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
admistrationdropdown.Click();
IWebElement tmoption = webDriver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3]"));
tmoption.Click();
IWebElement createNewButton = webDriver.FindElement(By.XPath("/html/body/div[4]/p/a "));
createNewButton.Click();
IWebElement typecodemaindropdown = webDriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodemaindropdown.Click();
IWebElement timeTypecode = webDriver.FindElement(By.XPath("//ul[@id='TypeCode_listbox']/li[2]"));
timeTypecode.Click();
IWebElement codeTextBox = webDriver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("ICApril2024");
IWebElement descriptionTextbox = webDriver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("ICApril2024Description");
IWebElement priceTextbox = webDriver.FindElement(By.XPath("//*[@id = \"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("250.00");

// Click on Select File 
IWebElement selectFilesButton = webDriver.FindElement(By.XPath("/html/body/div[4]/form/div/div[6]/div/div/div/div/input"));
selectFilesButton.SendKeys("C:\\Users\\Bhargav\\Pictures\\Sample.txt");

// Click on save button
IWebElement saveButton = webDriver.FindElement(By.Id("SaveButton"));
saveButton.Click();