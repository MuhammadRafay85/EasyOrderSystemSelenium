using System;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace EasyOrderSystemUnitTest
{
    [TestClass]
    public class MySeleniumTests
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;

        public MySeleniumTests()
        {
        }

        [TestMethod]
        [TestCategory("Chrome")]
        public void ThePosigentTest1()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            Wait(8);
            SelectFreeDeilvery();
            //SelectPickUp();
            SelectTimeButton();
            SelectTimeSlot();
           // ChangeGuestName();
            Assert.IsTrue(IsHomePageOpen(), "Verified");
            Assert.IsTrue(IsMenuAreaOpen(), "Verified");
            Assert.IsTrue(IsMenuItemOpen(), "Verified");
            Assert.IsTrue(IsChoicesOpen(), "Verified");
            SelectChoices();
            Assert.IsTrue(IsTotalEqual(), "Verified");
            RemoveMenuItem();
            Assert.IsTrue(IsTotalEqual(), "Verified");
            MobileNumberInput();
            FirstNameInput();
            LastNameInput();
            AddressInput();
            CityInput();
            StateInput();
            ZipInput();
            CCardInput();
            ExpiryInput();
            CVCInput();
            Wait(1);
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        internal bool IsHomePageOpen()
        {
            //var pageSource = driver.PageSource;
            IWebElement posigentlogo = (driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[1]")));
            if (posigentlogo.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        internal bool IsMenuAreaOpen()
        {
            //var pageSource = driver.PageSource;
            IWebElement menuArea = (driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div > div > span")));
            if (menuArea.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        internal bool IsMenuItemOpen()
        {
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div > div > span")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div > div > span")).Click();
                Wait(2);

            }
                
            //var pageSource = driver.PageSource;
            IWebElement menuItem = driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss82 > button:nth-child(3)"));
            if (menuItem.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        internal bool IsChoicesOpen()
        {
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss82 > button:nth-child(3)")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss82 > button:nth-child(3)")).Click();
                Wait(2);
               
            }
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss82 > button:nth-child(3)")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss82 > button:nth-child(3)")).Click();
                Wait(2);
            }


                //var pageSource = driver.PageSource;
                IWebElement choiceItem = (driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss44 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div.MuiBox-root.jss99 > div > div > div:nth-child(2) > svg")));
            if (choiceItem.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        internal void RemoveMenuItem()
        {
           if( IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss89 > button:nth-child(1) > span.MuiIconButton-label > svg")))
              {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss89 > button:nth-child(1) > span.MuiIconButton-label > svg")).Click();
              }
        }
        internal void SelectFreeDeilvery()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[1]/div/div/button[1]")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[1]/div/div/button[1]")).Click();
            }
        }
        internal void SelectPickUp()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[1]/div/div/button[2]")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[1]/div/div/button[2]")).Click();
            }
        }
        internal void SelectTimeButton()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/div[1]")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/div[1]")).Click();
            }
        }
        internal void SelectTimeSlot()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/div[2]/div/div/div/div/ul/div[3]/div/div/span")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[2]/div[3]/div[2]/div/div/div[2]/div/div/div/div/ul/div[3]/div/div/span")).Click();
            }
        }
        internal void ChangeGuestName()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[4]/div[1]/nav/div[1]/div/div/div[1]/div/span")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[4]/div[1]/nav/div[1]/div/div/div[1]/div/span")).Click();
            }
            if(IsElementPresent(By.XPath("//*[@id='name']")))
            {
                var guest=driver.FindElement(By.XPath("//*[@id='name']"));
                guest.Clear();
                guest.SendKeys("Test");

            }
            if (IsElementPresent(By.XPath("/ html / body / div[2] / div[3] / div / div[2] / button[2]")))
                {
                var submit = driver.FindElement(By.XPath("/ html / body / div[2] / div[3] / div / div[2] / button[2]"));
                submit.Click();
            
                 }

        }

        internal void MobileNumberInput()
        {
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(4) > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > div:nth-child(1) > div > div > input")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(4) > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > div:nth-child(1) > div > div > input")).Click();
                var moblieInput =driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(4) > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > div:nth-child(1) > div > div > input"));
                moblieInput.Clear();
                moblieInput.SendKeys("(619) 790-6310");
            }
          

        }
        internal void FirstNameInput()
        {
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(4) > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > div:nth-child(2) > div > div > input")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(4) > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > div:nth-child(2) > div > div > input")).Click();
                var fnameInput = driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(4) > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > div:nth-child(2) > div > div > input"));
                fnameInput.Clear();
                fnameInput.SendKeys("Tom");
            }


        }
        internal void LastNameInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[3]/div/div/input")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[3]/div/div/input")).Click();
                var lnameInput = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[3]/div/div/input"));
                lnameInput.Clear();
                lnameInput.SendKeys("Hanks");
            }


        }
        internal void AddressInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[4]/div/div/textarea[1]")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[4]/div/div/textarea[1]")).Click();
                var addInput = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[4]/div/div/textarea[1]"));
                addInput.Clear();
                addInput.SendKeys("7545 Edington Dr");
            }


        }
        internal void CityInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[5]/div/div/input")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[5]/div/div/input")).Click();
                var cityInput = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[5]/div/div/input"));
                cityInput.Clear();
                cityInput.SendKeys("Warrenton");
            }


        }
        internal void StateInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[6]/div/div/input")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[6]/div/div/input")).Click();
                var stateInput = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[6]/div/div/input"));
                stateInput.Clear();
                stateInput.SendKeys("VA");
            }


        }
        internal void ZipInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[7]/div/div/input")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[7]/div/div/input")).Click();
                var zipInput = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div[3]/div[2]/div/div[4]/div/div[2]/div/div/div[7]/div/div/input"));
                zipInput.Clear();
                zipInput.SendKeys("20187");
            }


        }
        internal void CCardInput()
        {
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(5) > div > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > form > div > div.MuiGrid-root.MuiGrid-item.MuiGrid-grid-xs-12 > div > div > div")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(5) > div > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > form > div > div.MuiGrid-root.MuiGrid-item.MuiGrid-grid-xs-12 > div > div > div")).Click();
                var zipInput = driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(5) > div > div > div.MuiPaper-root.MuiCard-root.MuiPaper-elevation1.MuiPaper-rounded > div > div > form > div > div.MuiGrid-root.MuiGrid-item.MuiGrid-grid-xs-12 > div > div > div > div"));
                //zipInput.Clear();
                zipInput.SendKeys("1234123412341234");
            }


        }
        internal void ExpiryInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/form/span[2]/span/input")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/form/span[2]/span/input")).Click();
                var zipInput = driver.FindElement(By.XPath("//*[@id='root']/form/span[2]/span/input"));
                zipInput.Clear();
                zipInput.SendKeys("12/21");
            }


        }
        internal void CVCInput()
        {
            if (IsElementPresent(By.XPath("//*[@id='root']/form/input[2]")))
            {
                driver.FindElement(By.XPath("//*[@id='root']/form/input[2]")).Click();
                var zipInput = driver.FindElement(By.XPath("//*[@id='root']/form/input[2]"));
                zipInput.Clear();
                zipInput.SendKeys("12/21");
            }


        }
        internal void SelectChoices()
        {
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div.MuiBox-root.jss99 > div > div > div:nth-child(2) > svg")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div.MuiBox-root.jss99 > div > div > div:nth-child(2) > svg")).Click();
            }
             Wait(2);
            //var pageSource = driver.PageSource;
            if (IsElementPresent(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div.MuiBox-root.jss99 > div > div > div:nth-child(2) > svg")))
            {
                driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > nav > div:nth-child(2) > li > div > div.MuiGrid-root.MuiGrid-item.MuiGrid-grid-xs-4 > span > span.MuiIconButton-label > input")).Click();
            }
            else
            {
                
            }


        }

        

        internal bool IsTotalEqual()
        {
            string total= driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiBox-root.jss49 > div > div > div.jss47 > div.MuiBox-root.jss51")).GetAttribute("innerHTML");
            Wait(1);
            string totalvalue = "";
            string stotalvalue = "";

            string stotal = driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div:nth-child(2) > div > div:nth-child(3) > div > div > div > div > div.MuiGrid-root.MuiGrid-container.MuiGrid-spacing-xs-1.MuiGrid-item.MuiGrid-justify-xs-flex-end.MuiGrid-grid-xs-7 > div:nth-child(1) > div > div > input")).GetAttribute("value");

                Wait(1);
            Regex regex = new Regex(@"\d+");

            var matches = regex.Matches(total);
            var smatches = regex.Matches(stotal);

            if (matches == null || matches.Count == 0)
                totalvalue= string.Empty;

            else

            {
                totalvalue= matches[0].Value;
            }
            if(smatches==null ||smatches.Count==0)
            {
                stotalvalue = string.Empty;
            }
            else

            {
                stotalvalue = smatches[0].Value;
            }
            //var pageSource = driver.PageSource;
           // IWebElement menuItem = (driver.FindElement(By.CssSelector("#root > div > div > div.jss9 > div > div:nth-child(4) > div.jss40 > nav > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div > div:nth-child(1) > div.MuiCollapse-container.MuiCollapse-entered > div > div > div > div:nth-child(1) > li > div.MuiListItemSecondaryAction-root.jss86 > button:nth-child(3)")));
            if (totalvalue==stotalvalue)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void SetupTest()
        {
            appURL = "https://posigentorder-test.azurewebsites.net/";

            string browser = "Chrome";
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
        internal static void Wait(int seconds)
        {
            Thread.Sleep(1000 * seconds);
        }
        internal  bool IsElementPresent(By by)
        {
            try
            {

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
        }
    }
}


