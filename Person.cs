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
    }
}