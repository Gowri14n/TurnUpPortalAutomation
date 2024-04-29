using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TUP_Automation1.Pages;
using TUP_Automation1.utilities;

namespace TUP_Automation1.Tests
{
    [TestFixture]
    public class TimeMaterialTests : CommonDriver
    {
        TimeAndMaterial tmobj = new TimeAndMaterial();
        [SetUp]
        public void SetUpTimeMaterial()
        {
             webDriver = new ChromeDriver();
            //Loginpage Initialization
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(webDriver);
            HomePage homepageobj = new HomePage();
            homepageobj.VerifyLoggedInUser(webDriver);
            homepageobj.NavigateToTimeMaterialPage(webDriver);
        }
        [Test,Order(1),Description("Create Test")]
        public void TestCreateTimeMaterialRecord()
        {
            //TimeandMaterial page initialization
            //TimeAndMaterial tmobj = new TimeAndMaterial();
            tmobj.CreateTMRecord(webDriver);
        }
        [Test,Order(3),Description("delete record")]
        public void TestUpdateTimeMaterialRecord() 
        {
            tmobj.EditTMRecord(webDriver);

        }
        [Test,Order(2),Description("update record")]
        public void TestDeleteTimeMaterialRecord() 
        {
            tmobj.DeleteTMRecord(webDriver);


        }
        [TearDown]
        public void CloseTestRun()
        {
            webDriver.Quit();
        }
    }
}
