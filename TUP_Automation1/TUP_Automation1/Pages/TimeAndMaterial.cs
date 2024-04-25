using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TUP_Automation1.utilities;

namespace TUP_Automation1.Pages
{
    public class TimeAndMaterial
    {
        public void CreateTMRecord(IWebDriver webDriver)
        {
            
            IWebElement createNewButton = webDriver.FindElement(By.XPath("/html/body/div[4]/p/a "));
            createNewButton.Click();

            WaitUtilis.WaitToBeVisible(webDriver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]",5);

            IWebElement typecodemaindropdown = webDriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodemaindropdown.Click();
            IWebElement timeTypecode = webDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeTypecode.Click();
            IWebElement codeTextBox = webDriver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("April2024");
            IWebElement descriptionTextbox = webDriver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("ICApril2024Description");

            WaitUtilis.WaitToBeVisible(webDriver, "XPath", "//*[@id = \"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 5);
            
            IWebElement priceTextbox = webDriver.FindElement(By.XPath("//*[@id = \"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("250.00");


            // Click on Select File 
            IWebElement selectFilesButton = webDriver.FindElement(By.XPath("/html/body/div[4]/form/div/div[6]/div/div/div/div/input"));
            selectFilesButton.SendKeys("C:\\Users\\Bhargav\\Pictures\\Sample.txt");

            WaitUtilis.WaitToBeVisible(webDriver, "Id", "SaveButton", 5);
            // Click on save button
            IWebElement saveButton = webDriver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            // verify create new record go to last page
            IWebElement goToLastPageButton = webDriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            VetifyRecordCreated(webDriver);

            // verify new record is created

            
        }
        public void EditTMRecord(IWebDriver webDriver) 
        {
            IWebElement editButton = webDriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            IWebElement saveButtonedit = webDriver.FindElement(By.Id("SaveButton"));
            saveButtonedit.Click();
            Thread.Sleep(5000);
        }
        public void DeleteTMRecord(IWebDriver webDriver) 
        { 
        
        }
        public void VetifyRecordCreated(IWebDriver webDriver)
        {
            IWebElement newCode = webDriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "April2024")
            {
                Console.WriteLine("New time record has been created successfully");
            }
            else
            {
                Console.WriteLine("New time record has not been created");
            }
            Thread.Sleep(2000);
        }
    }
}
