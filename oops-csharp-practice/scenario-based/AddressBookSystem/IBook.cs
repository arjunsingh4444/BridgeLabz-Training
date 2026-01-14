using System;

namespace AddressBookSystem
{
    public interface IBook
    {
        void AddContact(Contact contact);
        void DisplayContacts();
    }
}
