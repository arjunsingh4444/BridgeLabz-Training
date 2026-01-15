using System;

namespace BridgeLabzDup.oops_csharp_practice.scenario_based.address_book_system
{
    internal interface IAddressBook
    {
        void AddContact(); // Add a single contact
        void AddMultipleContactsMenu(); // Menu to add multiple contacts
        void EditContact(); // Edit a contact
        void DeleteContact(); // Delete a contact
        void SearchContact(); // Search for a contact
    }
}
