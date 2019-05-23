using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Demo
    {
        public int Max3(int a,int b,int c)
        {
            int m = a;
            if(m<b)
            {
                m = b;
            }
            if(m<c)
            {
                m = c;
            }
            return m;
        }
        public int Sum(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mult(int x, int y)
        {
            return x * y;
        }
        public string SayHello()
        {
            return "Welcome to Dotnet Testing...";
        }
    }
}
