using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NPOI.SS.UserModel;
using OpenQA.Selenium.Firefox;
using KDF_Test.Utility;
using System.Xml.Linq;
using System.Threading;

namespace KDF_Test.Keyword
{
    public class KeywordDrivenFramework
    {
        /********************** Declaration of variables **********************/

        //WebDriver instance for browser automation
        public static IWebDriver driver;
        //Interface in the Selenium WebDriver library that represents an HTML element on a webpage
        IWebElement element;


        /******************************* Methods ******************************/

        //Method that create a new ChromeDriver instance and assigns it to the driver variable
        public void openBrowser()
        {
            driver = new ChromeDriver();
            //Maximize the window
            driver.Manage().Window.Maximize();
        }

        //Implicit wait is a wait time applied to all the elements of the WebDriver instance, i.e., if a WebDriver instance has implicit wait
        //set to 10 seconds, then it will wait up to 10 seconds for every element to appear on the web page. If the element is found within 10 seconds,
        //the WebDriver will continue with the execution, otherwise, it will throw an exception.
        public void navigate()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(Constants.URL);
        }

        //Find a web element on web page and perform a click action on it
        public void clickSearch()
        {
            //Find the Search text box using xpath
            driver.FindElement(By.CssSelector("div.L3eUgb:nth-child(2) div.o3j99.ikrT4e.om7nvf:nth-child(3) div:nth-child(1) div.A8SBwf:nth-child(1) div.FPdoLc.lJ9FBc:nth-child(6) center:nth-child(1) > input.gNO89b")).Click();
        }

        //Find a web element (in this case, the search box) on the web page using XPath locator
        public void findSearchBox()
        {
            //Find the Search text box using xpath
            element = driver.FindElement(By.XPath("//*[@title='Search']"));
        }

        //Send keys
        public void enterText()
        {
            //Enter some text in search text box
            element.SendKeys("Test 1 Keyword Driven Framework");
        }

        //Close browser window that are opened by WebDriver
        public void closeBrowser()
        {
            driver.Quit();
        }

        //Pauses the execution for 5 seconds
        public void wait()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

    }

}
