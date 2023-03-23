using System.Collections.Generic;

namespace ShipmentCompany // replace YourNamespace with your own namespace
{
    public class Order
    {
        private Customer customer;
        private List<Product> products;

        // Constructor
        public Order(Customer customer)
        {
            this.customer = customer;
            this.products = new List<Product>();
        }

        // Method to add a product to the order
        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        // Method to compute the total price of the order
        public float ComputeTotalPrice()
        {
            float totalPrice = 0;

            foreach (Product product in this.products)
            {
                totalPrice += product.ComputePrice();
            }

            if (this.customer.IsInUSA())
            {
                totalPrice += 5;
            }
            else
            {
                totalPrice += 35;
            }

            return totalPrice;
        }

        // Method to get the packing label for the order
        public string GetPackingLabel()
        {
            string packingLabel = "";

            foreach (Product product in this.products)
            {
                packingLabel += $"{product.GetName()} ({product.GetId()}) - {product.GetPrice()} x {product.GetQuantity()}\n";
            }

            packingLabel += $"Shipping to {this.customer.GetFullName()} ({this.customer.GetAddress()})\n";
            packingLabel += $"Total price: {ComputeTotalPrice()}";

            return packingLabel;
        }
    }
}