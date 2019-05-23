using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;


namespace TestDemo
{
    [TestFixture]
    class TestEmp
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetUpTest()
        {
            homeURL = "http://localhost:50327/EmployInsert";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmployInsertSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtNAme")).SendKeys("Nishanth");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("txtDept")).SendKeys("Dotnet");
            driver.FindElement(By.Name("txtDesig")).SendKeys("Manager");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("txtBAsic")).SendKeys("89999");
            Thread.Sleep(3000);
            // Click on the Submit button
            driver.FindElement(By.Name("btnInsert")).Click();

            //StringAssert.AreEqualIgnoringCase("Record Inserted...", driver.Title);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
