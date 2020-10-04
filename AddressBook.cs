using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<Contact> list = new List<Contact>();
        public List<Contact> GetList()
        {
            return list;
        }
        public void AddAddress(Contact contact)
        {
            list.Add(contact);

        }
        public List<Contact> ViewAddressBook()
        {
            return list;
        }
    }
}
