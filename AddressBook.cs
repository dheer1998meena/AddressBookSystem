using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<Contact> list = new List<Contact>();
        private Dictionary<string, Contact> d = new Dictionary<string, Contact>();
        public List<Contact> GetList()
        {
            return list;
        }
        public Dictionary<string, Contact> GetDictionary()
        {
            return d;
        }
        public void AddAddress(string kname, Contact c)
        {
            list.Add(c);
            d.Add(kname, c);

        }
        public Contact ViewByKeyName(string kname)
        {
            foreach (KeyValuePair<string, Contact> kvp in d)
            {
                if (kvp.Key == kname)
                    return kvp.Value;
            }
            return null;
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
