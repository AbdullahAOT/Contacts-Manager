using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_Manager
{
    public class Contacts
    {
        public static List<string> contactsList = new List<string>();

        public static void ContactsManager()
        {
            Console.WriteLine("If you want to add new contact, enter A or a.\n"+
                "If you want to remove a contact, enter R or r.\n"+
                "If you want to view all contacts, enter V or v.");
            string? userOperation=Console.ReadLine();
            if(userOperation != null && userOperation!="")
            {
                List<string?> returnedListFromUser;
                if (userOperation.ToLower() == "a")
                {
                    Console.WriteLine("Enter contact name to add:");
                    string? contactName=Console.ReadLine();
                    while (contactName == "")
                    {
                        Console.WriteLine("Contact name cannot be empty, please enter a valid name:");
                        contactName = Console.ReadLine();
                    }
                    returnedListFromUser = AddContact(contactName);
                    Console.WriteLine("This is the updated contacts list:");
                    for (int i = 0; i < returnedListFromUser.Count; i++)
                    {
                        Console.WriteLine(returnedListFromUser[i]);
                    }
                }
                else if(userOperation.ToLower() == "r")
                {
                    Console.WriteLine("Enter contact name to remove:");
                    string? contactName = Console.ReadLine();
                    while (contactName == "")
                    {
                        Console.WriteLine("Contact name cannot be empty, please enter a valid name:");
                        contactName = Console.ReadLine();
                    }
                    returnedListFromUser = RemoveContact(contactName);
                    Console.WriteLine("This is the updated contacts list:");
                    for (int i = 0; i < returnedListFromUser.Count; i++)
                    {
                        Console.WriteLine(returnedListFromUser[i]);
                    }
                }
                else if(userOperation.ToLower() == "v")
                {
                    returnedListFromUser = ViewContacts();
                    Console.WriteLine("This is the list of your contacts:");
                    for (int i = 0; i < returnedListFromUser.Count; i++)
                    {
                        Console.WriteLine(returnedListFromUser[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid letter!");
                    ContactsManager();
                }
            }
        }

        public static List<string> AddContact(string contactName)
        {
            if (contactsList.Count == 0)
            {
                contactsList.Add(contactName);
                Console.WriteLine($"{contactName} was added successfully to contacts.");
                return contactsList;
            }
            else
            {
                bool alreadyExist = false;
                for (int i = 0; i < contactsList.Count; i++)
                {
                    if (contactName == contactsList[i])
                    {
                        alreadyExist = true;
                        break;
                    }
                }
                if (alreadyExist == true)
                {
                    Console.WriteLine("This name already exist in your contacts!");
                    return contactsList;
                }
                else
                {
                    contactsList.Add(contactName);
                    Console.WriteLine($"{contactName} was added successfully to contacts.");
                    return contactsList;
                }
            }
        }

        public static List<string> RemoveContact(string contactName)
        {
            if (contactsList.Count == 0)
            {
                Console.WriteLine("Your contacts list is already empty!");
                return contactsList;
            }
            else
            {
                int indexToRemove=-1;
                for (int i = 0; i < contactsList.Count; i++)
                {
                    if (contactName == contactsList[i])
                    {
                        indexToRemove = i;
                    }
                }
                if(indexToRemove < 0)
                {
                    Console.WriteLine("This contact name does not exist in your contacts list!");
                    return contactsList;
                }
                contactsList.Remove(contactsList[indexToRemove]);
                Console.WriteLine("Contact was removed successfully.");
                return contactsList;
            }
        }

        public static List<string> ViewContacts()
        {
            return contactsList;
        }

    }
}