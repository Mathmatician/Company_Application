﻿using System;
using Person_Space;

namespace Company_Application
{
    class Client : Person
    {
        // Initialization Variables //
        private long accountNumber = 0;


        /*---------------
         | Constructors |
         --------------*/
        public Client()
        {
            Console.WriteLine("This Client account is empty");
        }

        public Client(string fname, string lname, string addr, long pnum, long clntNum)
        {
            setFirstName(fname);
            setLastName(lname);
            setAddress(addr);
            setPhoneNumber(pnum);

            accountNumber = clntNum;
        }


        /*-------------------------
         | Returns Account Number |
         ------------------------*/
        public long getAccountNumber()
        {
            return accountNumber;
        }


        /*---------------------
         | Prints Client info |
         --------------------*/
        public override void PrintInfo()
        {
            Console.Write("Name:" + "\t\t\t"); Console.WriteLine(getName());
            Console.Write("Address:" + "\t\t"); Console.WriteLine(getAddress());
            Console.Write("Phone Number:" + "\t\t"); Console.WriteLine(getPhoneNumber());
            Console.Write("Account Number:" + "\t\t"); Console.WriteLine(getAccountNumber() + "\n");
        }
    }
}
