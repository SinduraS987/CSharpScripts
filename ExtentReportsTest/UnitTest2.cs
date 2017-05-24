using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ExtentReportsTest
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void LaunchBrowser()
        {
            Console.WriteLine("Test Case Name: LaunchBrowser");
            Console.WriteLine("Creating Chrome Browser Object");
            IWebDriver driver= new ChromeDriver();
            Console.WriteLine("Created Chrome Browser Object");
            Console.WriteLine("Launching URL");
            driver.Navigate().GoToUrl("http://10.10.11.174:4001/pages/registration.php");
            Console.WriteLine("Browser Title: " + driver.Title);
            Console.WriteLine("Browser URL: " + driver.Url);
            Console.WriteLine("Waiting for Page Load");
            Thread.Sleep(5000);
            Console.WriteLine("Closing Browser");
            driver.Quit();
            Console.WriteLine();
        }

        [Test]
        public void LaunchBrowser01()
        {
            Console.WriteLine("Test Case Name: LaunchBrowser01");
            Console.WriteLine("Creating Chrome Browser Object");
            IWebDriver driver = new ChromeDriver();
            Console.WriteLine("Created Chrome Browser Object");
            Console.WriteLine("Launching Google URL");
            driver.Navigate().GoToUrl("https://gmail.com");
            Console.WriteLine("Waiting for Page Load");
            Thread.Sleep(5000);
            Console.WriteLine("Closing Browser");
            driver.Quit();
            Console.WriteLine();
        }
    }
}
