
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
//using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        
        IWebDriver driver;
     
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("Testing 1");
            driver.FindElement((By.Name("q"))).SendKeys("test");

            System.Threading.Thread.Sleep(6000);



        }

        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("Testing 2");

        }

        [SetUp]
        public void login_test()
        {
            Console.WriteLine("Setup 1");
            //driver = new InternetExplorerDriver();
            driver = new ChromeDriver("F:\\Test_vs\\Drivers");
            //string testpath = "F:\\Test_vs\\Drivers";
            //driver = new ChromeDriver(Environment.GetEnvironmentVariable("testpath"));
            //driver = new ChromeDriver(testpath);
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TearDown]
        public void close_browser()
        {
            Console.WriteLine("closing browser 1");
            driver.Quit();
        }
    }
}