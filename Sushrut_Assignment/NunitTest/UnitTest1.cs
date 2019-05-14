using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SampleService;

namespace Tests
{ [TestFixture]
    public class AutomationTester
    {
      
        private static IWebDriver _driver;
       
        private string _applicationUrl = "http://shop.demoqa.com/";


        private void initiateBrowser()
        {
            
                ChromeOptions chromeoptions = new ChromeOptions()
                {

                };
            
                _driver = new ChromeDriver(@"C:\Users\rupali.gaikwad\Desktop\Selenium_Training\NunitTest\drivers");
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
            _driver.FindElement(By.XPath("//*[@class='noo-search']"));

            _driver.FindElement(By.XPath("//*[contains(text(),'Wishlist')]")); 

            _driver.FindElement(By.XPath("//*[@id='nav-menu-item-cart' or @class='menu-item noo-menu-item-cart minicart']"));

             _driver.FindElement(By.XPath("//*[@type='button' and @class='btn-navbar noo_icon_menu icon_menu']"));

             _driver.FindElement(By.XPath("//a[text()='Checkout']"));

            _driver.FindElement(By.XPath("//div[starts-with(@id,'cbox')]"));

            _driver.FindElement(By.XPath("//*[@class='pull-right noo-topbar-right']//following::li[1]"));

            _driver.FindElement(By.XPath("//*[text()='Checkout']//ancestor::div[1]"));
            _driver.FindElement(By.XPath("//*[@class='pull-right noo-topbar-right']/child::li[1]"));
             _driver.FindElement(By.XPath("//*[@class='pull-right noo-topbar-right']//preceding::li[2]"));
            _driver.FindElement(By.XPath("//*[@class='vc_row wpb_row vc_row-fluid padding-left90 vc_custom_1465282622143']//following-sibling::div"));
             _driver.FindElement(By.XPath("//*[@class='tp-caption   tp-resizeme']//parent::div[1]"));
              _driver.FindElement(By.XPath("//*[@class='tp-caption   tp-resizeme']//self::div"));
            _driver.FindElement(By.XPath("//*[@class='noo-services style_left image']//descendant::div[1]")); 
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        [Ignore("Unit Testing out of scope")]
        public void UnitTestDemo()
        {
         
        }
    }
}