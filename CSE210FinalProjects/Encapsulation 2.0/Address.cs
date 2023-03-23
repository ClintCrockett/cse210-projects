using System;

namespace MyNamespace
{
    // Address class
    public class Address
    {
        // Attributes
        private string street;
        private string city;
        private string state;
        private string country;

        // Constructor
        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        // Getter for the street attribute
        public string GetStreet()
        {
            return this.street;
        }

        // Getter for the city attribute
        public string GetCity()
        {
            return this.city;
        }

        // Getter for the state attribute
        public string GetState()
        {
            return this.state;
        }

        // Getter for the country attribute
        public string GetCountry()
        {
            return this.country;
        }

        // Method to check if the address is in the USA
        public bool IsInUSA()
        {
            return this.country == "USA";
        }

        // Method to return a formatted string of the address
        public string FullAddress()
        {
            return $"{this.street}\n{this.city}, {this.state} {this.country}";
        }
    }
}
