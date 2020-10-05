using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AddAddress(Contact c)
        {
            list.Add(c);

        }
        public List<Contact> ViewAddressBook()
        {
            return list;
        }
        public void EditNumber(String ename, String newnumber)
        {
            foreach (Contact cc in list)
            {
                if (cc.GetName().Equals(ename))
                {
                    cc.SetPhoneNo(newnumber);
                    Console.WriteLine("Number edited successfully");
                    break;
                }
            }
        }
        public void RemoveContact(String rname)
        {
            foreach (Contact cc in list)
            {
                if (cc.GetName().Equals(rname))
                {
                    list.Remove(cc);
                    Console.WriteLine("Number removed successfully");
                    break;
                }
            }
        }
    }
}
