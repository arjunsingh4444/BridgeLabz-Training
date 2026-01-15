using System;

namespace BridgeLabzDup.oops_csharp_practice.scenario_based.address_book_system
{
    internal class Contact
    {
        public string FirstName { get; set; } //Propertys of Contact class 
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }  


        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {PhoneNumber}, Email: {Email}";
        } 

        // UC --->7: Override Equals to check duplicate person by name
        public override bool Equals(object obj) //Override equals method
        {
            if (obj == null || !(obj is Contact))
                return false;

            Contact other = (Contact)obj; //Type casting

            return this.FirstName == other.FirstName && //Compare first name and last name
                   this.LastName == other.LastName; //Compare first name and last name
        }
    }
}
