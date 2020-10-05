﻿using System;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.Serialization;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            AddressBook ab = new AddressBook();
            do
            {
                Console.WriteLine("Enter your choice :");
                Console.WriteLine("1. Add Contact.");
                Console.WriteLine("2. View all Contacts.");
                Console.WriteLine("3.Edit existing contacts.");
                Console.WriteLine("4.Remove a contact.");
                Console.WriteLine("5.Exit.");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                    Console.WriteLine("Enter your Name : ");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter your address : ");
                    String address = Console.ReadLine();
                    Console.WriteLine("Enter your city : ");
                    String city = Console.ReadLine();
                    Console.WriteLine("Enter your state : ");
                    String state = Console.ReadLine();
                    Console.WriteLine("Enter your zip : ");
                    String zip = Console.ReadLine();
                    Console.WriteLine("Enter your contact no. : ");
                    String contactNo = Console.ReadLine();
                    Console.WriteLine("Enter your email : ");
                    String mailID = Console.ReadLine();

                    Contact c = new Contact(name, address, city, state, zip, contactNo, mailID);

                    ab.AddAddress(c);
                }
                else if (choice == 2)
                {
                    List<Contact> li = ab.ViewAddressBook();
                    foreach (Contact cl in li)
                    {
                        Console.WriteLine("Name : " + cl.GetName());
                        Console.WriteLine("Address : " + cl.GetAddress());
                        Console.WriteLine("City : " + cl.GetCity());
                        Console.WriteLine("State : " + cl.GetState());
                        Console.WriteLine("zip : " + cl.GetZip());
                        Console.WriteLine("Contact No. : " + cl.GetPhoneNo());
                        Console.WriteLine("Email ID : " + cl.GetEmail());
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the name :");
                    String ename = Console.ReadLine();
                    Console.WriteLine("Enter the new number for " + ename);
                    String newnumber = Console.ReadLine();
                    ab.EditNumber(ename, newnumber);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the name :");
                    String rname = Console.ReadLine();
                    ab.RemoveContact(rname);
                }
                else
                {
                    break;
                }
            } while (choice != 5);
        }
    }
    
}