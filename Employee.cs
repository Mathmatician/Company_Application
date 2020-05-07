using System;
using System.Globalization;

namespace Company_Application
{
    class Employee
    {
        // Initialization Variables //
        private string firstName = "";
        private string lastName = "";
        private string address = "";
        private long phoneNumber = 0;
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
            firstName = fname;
            lastName = lname;
            address = addr;
            phoneNumber = pnum;
            employeeNumber = empNum;
            salary = slry;
        }



        /*----------------
         | Set Functions |
         ---------------*/
        private void setFirstName(string fnm)
        {
            firstName = fnm;
        }

        private void setLastName(string lnm)
        {
            lastName = lnm;
        }

        private void setAddress(string addr)
        {
            address = addr;
        }

        private void setPhoneNumber(long pnum)
        {
            phoneNumber = pnum;
        }

        private void setEmployeeNumber(long num)
        {
            employeeNumber = num;
        }



        /*-------------------
         | Return functions |
         ------------------*/
        public string getName()
        {
            return firstName + " " + lastName;
        }

        public string getAddress()
        {
            return address;
        }

        public long getPhoneNumber()
        {
            return phoneNumber;
        }

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
        public void PrintInfo()
        {
            Console.Write("Name:" + "\t\t\t"); Console.WriteLine(getName());
            Console.Write("Address:" + "\t\t"); Console.WriteLine(getAddress());
            Console.Write("Phone Number:" + "\t\t"); Console.WriteLine(getPhoneNumber());
            Console.Write("Employee Number:" + "\t"); Console.WriteLine(getEmployeeNumber());
            Console.Write("Salary" + "\t\t\t"); Console.WriteLine(getSalary().ToString("C", CultureInfo.CurrentCulture) + "\n");
        }
    }
}
