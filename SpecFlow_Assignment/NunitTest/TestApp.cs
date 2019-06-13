using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

using System;

namespace Tests
{
    public class Tests
    {
         private static IWebDriver _driver;
       
        private string _applicationUrl = "https://www.idempiere.org/test-sites";
        private static DefaultWait<IWebDriver> fluentWait;

        private void initiateBrowser()
        {
            
                ChromeOptions chromeoptions = new ChromeOptions()
                {

                };
            
                _driver = new ChromeDriver(@"C:\Users\rupali.gaikwad\Desktop\SpecFlow_Assignment\NunitTest\drivers");
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
            //login to application
            loginform();
            
            //wait for finding element
            fluentWait = new DefaultWait<IWebDriver>(_driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

                //to find business partner
                findbusinesspartner();

                //to close open form
                closeform();
                
                findbusinesspartner();

                //fill the open form
                 fillform();

                 //reset all fields
                resetfun();

                //fill all fields
                 fillform();

                okaylookuprecord();

                //to open new form
                opennewform();

                //fill mandatory fields
                fillmandfileds();
                 
              //save changes made in form
              saveform();
               
        }  

        public void loginform(){
            _driver.FindElement(By.XPath("//*[@class='dhtgD aw5Odc']")).Click();
            
            //switch window control to current window
            IList<string> mylist=_driver.WindowHandles;
             foreach (var item in mylist){
                 if(item!=_driver.CurrentWindowHandle){
                     _driver.SwitchTo().Window(item);
                 }
             }
            IWebElement uname= _driver.FindElement(By.XPath("//input[@autocomplete='username']"));       
             IWebElement pass=_driver.FindElement(By.XPath("//input[@autocomplete='current-password']"));       
             uname.SendKeys("admin @ gardenworld.com");
             pass.SendKeys("GardenAdmin");

            // IWebElement chbox=_driver.FindElement(By.XPath("//input[@tabindex='-1']"));
             //chbox.Click();
             IWebElement okbutton=_driver.FindElement(By.XPath("//button[contains(text(),'OK')]"));
             okbutton.Click();  


        }
        
        public void findbusinesspartner(){
            
            IWebElement businesspartner = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
           
             businesspartner.Click();

        }
        public void closeform(){
                IWebElement cancelbutton = fluentWait.Until(x=>x.FindElement(By.XPath("//button[@title='Cancel']")));
             cancelbutton.Click(); 
        }
         public void fillform(){
              IWebElement searchkeyinput = fluentWait.Until(x=>x.FindElement(By.XPath("//input[@instancename='Value']")));
                searchkeyinput.SendKeys("abc");
                IWebElement nameinput = fluentWait.Until(x=>x.FindElement(By.XPath("//input[@instancename='Name']"))); 
                  nameinput.SendKeys("dfg");
                IWebElement name2input = fluentWait.Until(x=>x.FindElement(By.XPath("//input[@instancename='Name2']")));
                 name2input.SendKeys("cvbb");
                 IWebElement descriptioninput = fluentWait.Until(x=>x.FindElement(By.XPath("//input[@instancename='Description']")));
                 descriptioninput.SendKeys("desc");

         }
         public void resetfun(){
                IWebElement resetbutton = fluentWait.Until(x=>x.FindElement(By.XPath("//button[@title='Reset']")));
                    resetbutton.Click(); 
         }

         public void okaylookuprecord(){
             IWebElement okaybutton = fluentWait.Until(x=>x.FindElement(By.XPath("//button[@title='OK']")));
                       okaybutton.Click(); 
                        }

         public void opennewform(){
             IWebElement newformbutton = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='New    Alt+N']")));
                       newformbutton.Click(); 
         } 
         
         public void fillmandfileds(){
             IWebElement fillname = fluentWait.Until(x=>x.FindElement(By.XPath("//input[@title='Alphanumeric identifier of the entity']")));
                fillname.SendKeys("test name");    
         } 
         public void saveform(){
             IWebElement saveformbutton = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Save changes    Alt+S']")));
                       saveformbutton.Click(); 
         } 
         
      [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }  
    }
}