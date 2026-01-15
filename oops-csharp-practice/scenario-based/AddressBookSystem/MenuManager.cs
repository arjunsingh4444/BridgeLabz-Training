using System;

namespace BridgeLabzDup.oops_csharp_practice.scenario_based.address_book_system
{
    internal class MenuManager
    {
        private static AddressBook[] addressBooks = new AddressBook[10]; // Maximum 10 Address Books
        private static string[] addressBookNames = new string[10]; // Names of Address Books
        private static int bookCount = 0; // Counter for Address Books

        public static void DisplayMenu() //Display main menu
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Multiple Address Book Menu ---");
                Console.WriteLine("1. Create New Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateNewAddressBook();
                        break;
                    case 2:
                        SelectAddressBook();
                        break;
                    case 0:
                        Console.WriteLine("Program Ended");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 0);
        }

        private static void CreateNewAddressBook() //Create new address book
        {
            if (bookCount >= addressBooks.Length) //Check if maximum address books reached
            {
                Console.WriteLine("Maximum Address Books reached!\n");
                return;
            }

            Console.Write("Enter Name for New Address Book: ");
            string name = Console.ReadLine();

            for (int i = 0; i < bookCount; i++) //Check for duplicate names
            {
                if (addressBookNames[i] == name) //If name already exists
                {
                    Console.WriteLine("Address Book with this name already exists!\n");
                    return;
                }
            }

            addressBooks[bookCount] = new AddressBook(name); //Create new address book
            addressBookNames[bookCount] = name;
            bookCount++;

            Console.WriteLine($"Address Book '{name}' Created Successfully\n");
        }

        private static void SelectAddressBook() //Select existing address book
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No Address Books available\n"); //No address books to select
                return;
            }

            for (int i = 0; i < bookCount; i++)
                Console.WriteLine($"{i + 1}. {addressBookNames[i]}"); //        List available address books

            Console.Write("Select Address Book: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > bookCount)
            {
                Console.WriteLine("Invalid Choice\n");
                return;
            }

            AddressBookMenu(addressBooks[choice - 1]);
        }

        private static void AddressBookMenu(AddressBook book) //Menu for selected address book
        {
            int choice;
            do
            {
                Console.WriteLine($"\n--- Address Book: {book.Name} ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Add Multiple Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("0. Go Back");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        book.AddContact();
                        break;
                    case 2:
                        book.AddMultipleContactsMenu();
                        break;
                    case 3:
                        book.EditContact();
                        break;
                    case 4:
                        book.DeleteContact();
                        break;
                }

            } while (choice != 0); //Go back to main menu
        }
    }
}
