using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public Dictionary<string, Contact> contactList = new Dictionary<string, Contact>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contact addNewContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            contactList.Add(firstName + lastName, addNewContact);
            Console.WriteLine("Contact Added");
        }

        public void DisplayPhoneNumber(string Name)
        {
            foreach (KeyValuePair<string, Contact> keyValuePair in contactList)
            {
                if ((keyValuePair.Key).Contains(Name))
                    Console.WriteLine("Phone number of searched {0} is {1}", Name, (keyValuePair.Value).phoneNumber);
            }
        }
    }
}
