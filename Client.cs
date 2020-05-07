using System;

namespace Company_Application
{
    class Client
    {
        // Initialization Variables //
        private string firstName = "";
        private string lastName = "";
        private string address = "";
        private long phoneNumber = 0;
        private long accountNumber = 0;

        public Client()
        {
            Console.WriteLine("This Client account is empty");
        }

        public Client(string fname, string lname, string addr, long pnum, long clntNum)
        {
            firstName = fname;
            lastName = lname;
            address = addr;
            phoneNumber = pnum;
            accountNumber = clntNum;
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
            accountNumber = num;
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
            return accountNumber;
        }


        /*---------------------
         | Prints Client info |
         ---------------------*/
        public void PrintInfo()
        {
            Console.Write("Name:" + "\t\t\t"); Console.WriteLine(getName());
            Console.Write("Address:" + "\t\t"); Console.WriteLine(getAddress());
            Console.Write("Phone Number:" + "\t\t"); Console.WriteLine(getPhoneNumber());
            Console.Write("Account Number:" + "\t\t"); Console.WriteLine(getEmployeeNumber() + "\n");
        }
    }
}
