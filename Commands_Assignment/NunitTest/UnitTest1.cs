using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Tests
{
     [TestFixture]
    public class AutomationTester
    {
      
        private static IWebDriver _driver;
       
        private string _applicationUrl = "http://shop.demoqa.com/";


        private void initiateBrowser()
        {
            
               FirefoxOptions firefoxoptions = new FirefoxOptions()
            {
                AcceptInsecureCertificates = true,
            };
            _driver = new FirefoxDriver(@"C:\Users\rupali.gaikwad\Desktop\Commands_Assignment\NunitTest\drivers", firefoxoptions);
                
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
            _driver.FindElement(By.XPath("//*[@class='noo-search']")).Click();
             
             _driver.Navigate().Back();
          
             _driver.Navigate().Forward();
             
                _driver.Navigate().Refresh();

        }
        [Test]
        [Ignore("Unit Testing out of scope")]
        public void Test_Demo() {
            _driver.Url=_applicationUrl;

            //_driver.Manage().Timeouts().ImplicitWait.(new TimeSpan(0, 0, timeout));
            _driver.Manage().Cookies.DeleteAllCookies();
            //maximize the browser window
            _driver.Manage().Window.Maximize();
             string Title = _driver.Title;
             Console.WriteLine("Page title:{0}",Title.Length);
             string Url = _driver.Url;
             Console.WriteLine("Page title:{0}",Url.Length);
             string PageSource = _driver.PageSource;
             Console.WriteLine("Page title:{0}",PageSource.Length);
        }
         [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}