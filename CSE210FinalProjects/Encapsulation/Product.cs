using System;

public class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public float TotalPrice { get; set; }

    public void ComputePrice()
    {
        TotalPrice = Price * Quantity;
    }
}
