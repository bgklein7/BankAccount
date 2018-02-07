using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ClientInfo
    {
        //fields
        //invisible

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        //Constructors
        public ClientInfo()
        {
            //default constructor
        }

        public ClientInfo(string firstName, string lastName, int houseNumber, string streetName, string city, string state, int zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            HouseNumber = houseNumber;
            StreetName = streetName;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        //Methods
        public void ViewInfo()
        {
            Console.WriteLine("Name: " + LastName + ", " + FirstName);
            Console.WriteLine("Address:");
            Console.WriteLine(HouseNumber + " " + StreetName);
            Console.WriteLine(City + ", " + State);
            Console.WriteLine(ZipCode);
        }
    }
}
