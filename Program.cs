using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Relen_Project
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {


        }
        [SetUp]
        public void InitializeTest()
        {
            driver.Navigate().GoToUrl("https://www.relen.io");
        }
        [Test]
        public void ExecuteTest()
        {
            driver.Manage().Window.Maximize();
            


        }
        //[TearDown]
        //public void EndTest()
        //{
        //  driver.Quit();
        //}


    }
}




