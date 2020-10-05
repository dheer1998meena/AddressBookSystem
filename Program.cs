using System;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.Serialization;

namespace AddressBookSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook addressBook = new AddressBook();

            // Adding contact into address book
            addressBook.AddContact("first", "Last", "Street NO: 107", "Londan", "UnitedKingdom", "123456", "1234567891", "sample@example.com");

            // Searching phone Number by contact name
            addressBook.DisplayPhoneNumber("first");
        }
    }
}