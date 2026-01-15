using System;

namespace BridgeLabzDup.oops_csharp_practice.scenario_based.address_book_system
{
    internal class AddressBook : IAddressBook //Implementing IAddressBook interface
    {
        private Contact[] contacts = new Contact[50]; //Array to store contacts
        private int count = 0; //Counter for contacts

        public string Name;

        public AddressBook(string name) //Constructor
        {
            Name = name;
        }

        // UC-7: Add contact with duplicate check
        public void AddContact()
        {
            if (count >= contacts.Length) //Check if array is full
            {
                Console.WriteLine("Address Book is Full\n"); 
                return;
            }

            Contact contact = new Contact(); //Creating new contact

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            // Duplicate check
            for (int i = 0; i < count; i++) //Iterate through existing contacts
            {
                if (contacts[i].Equals(contact))
                {
                    Console.WriteLine("Duplicate Contact Found. Cannot Add Same Person Again\n"); 
                    return;
                }
            }

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            contacts[count] = contact;
            count++;

            Console.WriteLine("Contact Added Successfully\n");
        }

        public void AddMultipleContactsMenu() //Menu to add multiple contacts
        {
            int choice;
            do
            {
                Console.WriteLine($"\n--- Add Contacts to Address Book: {Name} ---");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("0. Go Back");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);
        }

        public void EditContact() //Edit contact
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++) //Iterate through contacts
            {
                if (contacts[i].FirstName == name) //If first name matches
                {
                    Console.Write("Enter New Address: ");
                    contacts[i].Address = Console.ReadLine();

                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.Write("Enter New Zip: ");
                    contacts[i].Zip = Console.ReadLine();

                    Console.Write("Enter New Phone Number: ");
                    contacts[i].PhoneNumber = Console.ReadLine();

                    Console.Write("Enter New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully\n");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found\n");
        }

        public void DeleteContact() //Delete contact
        {
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName == name) //If first name matches
                {
                    for (int j = i; j < count - 1; j++) //Shift contacts to delete the contact
                        contacts[j] = contacts[j + 1]; //Shift contacts
 
                    contacts[count - 1] = null; //Remove last duplicate contact
                    count--; //Decrement count

                    Console.WriteLine("Contact Deleted Successfully\n"); //Confirmation message
                    return;
                }
            }

            Console.WriteLine("Contact Not Found\n");
        }
    }
}
