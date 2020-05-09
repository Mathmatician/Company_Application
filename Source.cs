using System;

namespace Company_Application
{
    class Source
    {
        static void Main(string[] args)
        {
            // Employee emp = new Employee("FirstName", "LastName", "Address", PhoneNumber, EmployeeNumber, Salary);
            Employee Albert = new Employee("Albert", "Einstein", "3450 Thunderbluff, New York, NY, 58156", 123456789, 117, 1000000000);
            Albert.PrintInfo();

            // Client clnt = new Client("FirstName", "LastName", "Address", PhoneNumber, AccountNumber);
            Client Paul = new Client("Paul", "Dirac", "5236N Iron Forge Way, Salt Lake City, Utah, 85214", 6543219876, 343);
            Paul.PrintInfo();
            
            Console.ReadKey();
        }
    }
}

