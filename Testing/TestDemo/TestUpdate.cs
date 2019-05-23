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
    class TestUpdate
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetUpTest()
        {
            homeURL = "http://localhost:50327/EmpUpdate";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmployUpdateSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtEmpno")).SendKeys("4" +Keys.Enter);
            driver.FindElement(By.Name("txtEmpno")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtNAme")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtNAme")).SendKeys("David Guetta");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtDept")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtDept")).SendKeys("EDM");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtDesig")).Clear();
            driver.FindElement(By.Name("txtDesig")).SendKeys("DJ");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtBAsic")).Clear();
            driver.FindElement(By.Name("txtBAsic")).SendKeys("789880");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("btnUpdate")).Click();
            //Type LastName in the LastName text box
            string result = driver.FindElement(By.Id("lblResult")).Text.ToString();
            //string result = driver.FindElement(By.CssSelector("span")).Text;
            StringAssert.AreEqualIgnoringCase("Record Updated...", result);
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
