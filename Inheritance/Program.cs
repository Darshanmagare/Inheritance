using Inheritance;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SSE obj = new SSE();
            Employee obj3 = new SSE();
            Employee obj4 = new SE();
            //Console.WriteLine("Hello World!");
        }
    }

    class Employee
    {
        
        internal int empid;
        internal string fname;
        internal string sname;
       
    }

    class SE : Employee
    {
    public string designation = "Software Engineer";
    public void PrintSEDetails()
    {
        empid = 101;
        fname = "Mike";
        lname = "Methew";
        Console.WriteLine(empid);
        Console.WriteLine(fname);
        Console.WriteLine(lname);
    }
    }
    class SSE : Employee
    {
        public string designation = "Software Engineer";
        public void PrintSSEDetails()
        {
            empid = 102;
            fname = "Mikes";
            lname = "Methews";
            Console.WriteLine(empid);
            Console.WriteLine(fname);
            Console.WriteLine(lname);
        }
    }
}
