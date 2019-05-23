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
    class TestGoogle
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://www.google.com";
            driver = new ChromeDriver();
        }
        [Test]
        public void GoogleTest()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            StringAssert.Contains("Google", driver.Title);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("India Worldcup squad in 2019");
            query.Submit();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
