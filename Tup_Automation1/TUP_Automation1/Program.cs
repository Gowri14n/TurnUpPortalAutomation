using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TUP_Automation1.Pages;

internal class Program
{
    public static void Main(string[] args)
    {
        IWebDriver webDriver = new ChromeDriver();
        //Loginpage Initialization
        LoginPage loginpageobj = new LoginPage();
        loginpageobj.LoginActions(webDriver);

        // Homepage Object Initialization
        HomePage homepageobj = new HomePage();
        homepageobj.VerifyLoggedInUser(webDriver);
        homepageobj.NavigateToTimeMaterialPage(webDriver);

        //TimeandMaterial page initialization
        TimeAndMaterial tmobj = new TimeAndMaterial();
        tmobj.CreateTMRecord(webDriver);
        tmobj.EditTMRecord(webDriver);
        tmobj.DeleteTMRecord(webDriver);
        
        
    }
}