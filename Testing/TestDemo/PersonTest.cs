using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestDemo
{
    class PersonTest
    {
        Person person;
        [SetUp]
        public void init()
        {
            person = new Person();
        }
        [Test]
        public void TestException()
        {
            Assert.Throws<MissingFieldException>(TestName);
        }
        [Test]
        public void TestExceptionLamda()
        {
            person.Fname = "Arun";
            person.Mname = "YAdav";
           Assert.Throws<MissingFieldException>(()=>person.GetFullName());
        }
        private void TestName()
        {
            person.Fname = "Arun";
            person.Mname = "YAdav";
            string res = person.GetFullName();
        }
        public void FullName()
        {
            person.Fname = "Arun";
            person.Mname = "J";
            person.Lname = "Yadav";
            Assert.AreEqual("Arun J Yadav", person.GetFullName());
        }
    }
}
