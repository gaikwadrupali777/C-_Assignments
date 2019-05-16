using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tests
{
   [TestFixture]
    public class AutomationTester
    {
      
        private static IWebDriver _driver;
       
        private string _applicationUrl = "https://www.toolsqa.com/automation-practice-form/";


        private void initiateBrowser()
        {
            
               FirefoxOptions firefoxoptions = new FirefoxOptions()
            {
                AcceptInsecureCertificates = true,
            };
            _driver = new FirefoxDriver(@"C:\Users\rupali.gaikwad\Desktop\Checkbox&Radiobutoon_assignment\NunitTest\drivers", firefoxoptions);
                
            return;
        }

        [SetUp]
        public void Setup()
        {
            initiateBrowser();
        }
        [Test]
        public void TestDemo() {
           _driver.Navigate().GoToUrl(_applicationUrl);

            //_driver.Manage().Timeouts().ImplicitWait.(new TimeSpan(0, 0, timeout));
            _driver.Manage().Cookies.DeleteAllCookies();
            //maximize the browser window
            _driver.Manage().Window.Maximize();
           
            IList<IWebElement> rdBtn_Sex = _driver.FindElements(By.Name("sex"));
 
            // Create a boolean variable which will hold the value (True/False)
            Boolean bValue = false;
 
            // This statement will return True, in case of first Radio button is selected
            bValue = rdBtn_Sex.ElementAt(0).Selected;
 
            // This will check that if the bValue is True means if the first radio button is selected
            if (bValue == true)
            {
                // This will select Second radio button, if the first radio button is selected by default
                rdBtn_Sex.ElementAt(1).Click();
            }
            else
            {
                // If the first radio button is not selected by default, the first will be selected
                rdBtn_Sex.ElementAt(0).Click();
            }
 
            //Step 4: Select the Third radio button for category 'Years of Exp' (Use Id attribute to select Radio button)
            IWebElement rdBtn_Exp = _driver.FindElement(By.Id("exp-2"));
            rdBtn_Exp.Click();

            // Step 5: Check the checkbox 'Automation Tester' for category 'Profession'( Use Value attribute to match the selection)
            // Find the checkbox or radio button element by Name
            IList<IWebElement> chkBx_Profession = _driver.FindElements(By.Name("profession"));
            // This will tell you the number of checkboxes are present
 
            int iSize = chkBx_Profession.Count;
 
            // Start the loop from first checkbox to last checkboxe
            for (int i = 0; i < iSize; i++)
            {
                // Store the checkbox name to the string variable, using 'Value' attribute
                String Value = chkBx_Profession.ElementAt(i).GetAttribute("value");
 
                // Select the checkbox it the value of the checkbox is same what you are looking for
                if (Value.Equals("Automation Tester"))
                {
                    chkBx_Profession.ElementAt(i).Click();
                    // This will take the execution out of for loop
                    break;
                }
 
             
        }
        }
       
         [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    
}
}