using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using KDF_Test.Keyword;
using OpenQA.Selenium.Interactions;
using KDF_Test;

namespace KDF_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ReadExcelData rs = new ReadExcelData();
            rs.ReadExcelDataSheet(4);

            KeywordDrivenFramework ak = new KeywordDrivenFramework();

            //Test 1
            ak.openBrowser();
            ak.navigate();
            ak.findSearchBox();
            ak.enterText();
            ak.clickSearch();
            ak.wait();
            ak.closeBrowser();


        }

    }
}
