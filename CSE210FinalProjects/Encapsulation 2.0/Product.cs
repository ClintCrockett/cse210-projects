namespace ShipmentCompany // replace with your own namespace
{
    public class Product
    {
        private string name;
        private int id;
        private float price;
        private int quantity;

        // Constructor
        public Product(string name, int id, float price, int quantity)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }

        // Getter for the name attribute
        public string GetName()
        {
            return this.name;
        }

        // Getter for the id attribute
        public int GetId()
        {
            return this.id;
        }

        // Getter for the price attribute
        public float GetPrice()
        {
            return this.price;
        }

        // Setter for the quantity attribute
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        // Method to compute the total price of the product
        public float ComputePrice()
        {
            return this.price * this.quantity;
        }
    }
}
