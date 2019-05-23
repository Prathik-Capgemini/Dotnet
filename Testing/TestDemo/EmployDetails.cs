using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class EmployDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public string Login(string userId,string password)
        {
            if(string.IsNullOrEmpty(userId)||
                    string.IsNullOrEmpty(password))
                {
                return "Userid or password could  not be Empty.";

                }
            else
            {
                if(userId=="Admin" && password=="Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }
        public List<EmployDetails> AllUsers()
        {
            List<EmployDetails> li = new List<EmployDetails>();
            li.Add(new EmployDetails
            {
                Id = 100,
                Name = "Bharat",
                Gender = "male",
                Salary = 40000
            });
            li.Add(new EmployDetails
            {
                Id = 101,
                Name = "Nishanth",
                Gender = "male",
                Salary = 35000
            });
            li.Add(new EmployDetails
            {
                Id = 101,
                Name = "Pawan",
                Gender = "male",
                Salary = 55000
            });
            li.Add(new EmployDetails
            {
                Id = 101,
                Name = "Suhas",
                Gender = "Unknown",
                Salary = 75000
            });
            return li;
        }
        public  List<EmployDetails> GetDetails(int id)
        {
            List<EmployDetails> li1 = new List<EmployDetails>();
            var li = new EmployDetails().AllUsers();
            foreach(var x in li)
            {
                if(x.Id==id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
    }
}
