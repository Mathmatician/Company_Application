using System;

namespace Person_Space
{
    class Person
    {
        // Initialization Variables //
        protected string firstName = "";
        protected string lastName = "";
        protected string address = "";
        protected long phoneNumber = 0;


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
