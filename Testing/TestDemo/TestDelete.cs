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
    class TestDelete
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetUpTest()
        {
            homeURL = "http://localhost:50327/EmpDelete";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmployDeleteSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(1000);
            driver.FindElement(By.Name("txtEmpno")).SendKeys("9321");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("btnDelete")).Click();
            string result = driver.FindElement(By.Id("lblResult")).Text.ToString();
            StringAssert.AreEqualIgnoringCase("Records Deleted", result);
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
    
}
