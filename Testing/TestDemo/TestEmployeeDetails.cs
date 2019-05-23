using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestDemo
{
    [TestFixture]
    class TestEmployeeDetails
    {
        [Test]
        public void TestLogin()
        {
            EmployDetails pobj = new EmployDetails();
            string x = pobj.Login("Ajit", "1234");
            string y = pobj.Login("", "");
            string z = pobj.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could  not be Empty.",y);
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Welcome Admin.", z);

        }
        [Test]
        public void  GetUserDetails()
        {
            EmployDetails pobj = new EmployDetails();
            var p = pobj.GetDetails(100);
            foreach(var x in p)
            {
                Assert.AreEqual(x.Id, 100);
                Assert.AreEqual(x.Name, "Bharat");
            }
        }
       
        List<EmployDetails> li;
        [Test]
        public void CheckDetails()
        {
            EmployDetails pobj = new EmployDetails();
            li = pobj.AllUsers();
            foreach(var x in li)
            {
                Assert.IsNotNull(x.Id);
                Assert.IsNotNull(x.Name);
                Assert.IsNotNull(x.Salary);
                Assert.IsNotNull(x.Gender);

            }
        }
    }
  
   
}
