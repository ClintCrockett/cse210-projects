class Customer
{

    private string AR_customer_name;

    private Address AR_address;


    public Customer(string name, Address address)
    {
        this.AR_customer_name = name;
        this.AR_address = address;
    }

    public string GetName()
    {
        return AR_customer_name;
    }
    public bool isinUSA()
    {
        return AR_address.intheUSA();
    }

    public Address GetAddress()
    {
        return AR_address;
    }
}