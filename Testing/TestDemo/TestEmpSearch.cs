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
    class TestEmpSearch
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetUpTest()
        {
            homeURL = "http://localhost:50327/EmpSearch";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmploySearchSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtEmpno")).SendKeys("1");
            driver.FindElement(By.Name("btnSearch")).Click();
            //Type LastName in the LastName text box
            string name = driver.FindElement(By.Name("txtNAme")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("Rajath", name);
            string dept = driver.FindElement(By.Name("txtDept")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("Android", dept);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
