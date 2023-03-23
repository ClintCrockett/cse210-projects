using System;


public class Order
{
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
    public float TotalPrice { get; set; }

    public void ComputeTotalPrice()
    {
        TotalPrice = 0;
        foreach (Product product in Products)
        {
            product.ComputePrice();
            TotalPrice += product.TotalPrice;
        }
    }

    public string GetShippingLabel()
    {
        return Customer.Name + "\n" + Customer.Address.FullAddress();
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in Products)
        {
            packingLabel += "Name: " + product.Name + ", ID: " + product.Id + "\n";
        }
        return packingLabel;
    }
}
