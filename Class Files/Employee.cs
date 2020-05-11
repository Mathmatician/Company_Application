using System;
using System.Globalization;
using Person_Space;

namespace Company_Application
{
    class Employee : Person
    {
        // Initialization Variables //
        private long employeeNumber = 0;
        private double salary = 0;
        

        /*---------------
         | Constructors |
         --------------*/
        public Employee()
        {
            Console.WriteLine("This Employee account is empty");
        }

        public Employee(string fname, string lname, string addr, long pnum, long empNum, double slry)
        {
            setFirstName(fname);
            setLastName(lname);
            setAddress(addr);
            setPhoneNumber(pnum);

            employeeNumber = empNum;
            salary = slry;
        }
        

        /*----------------
         | Set Functions |
         ---------------*/

        public void setSalary(double slry)
        {
            salary = slry;
        }


        /*-------------
         | Get Salary |
         ------------*/

        public long getEmployeeNumber()
        {
            return employeeNumber;
        }

        public double getSalary()
        {
            return salary;
        }


        /*-----------------------
         | Prints employee info |
         ----------------------*/
        public override void PrintInfo()
        {
            Console.Write("Name:" + "\t\t\t"); Console.WriteLine(getName());
            Console.Write("Address:" + "\t\t"); Console.WriteLine(getAddress());
            Console.Write("Phone Number:" + "\t\t"); Console.WriteLine(getPhoneNumber());
            Console.Write("Employee Number:" + "\t"); Console.WriteLine(getEmployeeNumber());
            Console.Write("Salary" + "\t\t\t"); Console.WriteLine(getSalary().ToString("C", CultureInfo.CurrentCulture) + "\n");
        }
    }
}
