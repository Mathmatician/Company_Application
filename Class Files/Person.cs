using System;

namespace Person_Space
{
    class Person
    {
        // Initialization Variables //
        private string firstName = "";
        private string lastName = "";
        private string address = "";
        private long phoneNumber = 0;


        /*----------------
         | Set Functions |
         ---------------*/
        public void setFirstName(string fnm)
        {
            firstName = fnm;
        }

        public void setLastName(string lnm)
        {
            lastName = lnm;
        }

        public void setAddress(string addr)
        {
            address = addr;
        }

        public void setPhoneNumber(long pnum)
        {
            phoneNumber = pnum;
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


        /*-------------
         | Print Info |
         ------------*/
         public virtual void PrintInfo()
        {
            Console.Write("Name:" + "\t\t\t"); Console.WriteLine(getName());
            Console.Write("Address:" + "\t\t"); Console.WriteLine(getAddress());
            Console.Write("Phone Number:" + "\t\t"); Console.WriteLine(getPhoneNumber());
        }
    }
}
