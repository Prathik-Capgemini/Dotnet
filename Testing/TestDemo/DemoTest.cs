using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestDemo
{
    [TestFixture]
    class DemoTest
    {
      
        [Test]
        public void TestMax3()
        {
            Assert.AreEqual(5, new Demo().Max3(5, 2, 3));
            Assert.AreEqual(5, new Demo().Max3(2, 5, 3));
            Assert.AreEqual(5, new Demo().Max3(3, 5, 2));

        }
        [Test]
        public void TestCalc()
        {
            int res = new Demo().Sum(2, 5);
            Assert.AreEqual(7, res);
            res = new Demo().Sub(2, 5);
            Assert.AreEqual(-3, res);
            res = new Demo().Mult(2, 5);
            Assert.AreEqual(10, res);
        }
        [Test]
        public void TestSayHello()
        {
            string res1 = new Demo().SayHello();
            Assert.AreEqual(res1, "Welcome to Dotnet Testing...");
        }
    }
}
