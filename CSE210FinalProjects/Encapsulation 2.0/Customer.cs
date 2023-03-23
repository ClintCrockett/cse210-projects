namespace ShipmentCompany
{
    public class Customer
    {
        private string name;
        private Address address;

        // Constructor
        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        // Getter for the name attribute
        public string GetName()
        {
            return this.name;
        }

        // Method to check if the customer is in the USA
        public bool IsInUSA()
        {
            return this.address.IsInUSA();
        }
    }
}
