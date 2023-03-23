class Product{

    private string AR_name;
    private string AR_productId;
    private double AR_price;
    private int AR_quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.AR_name = name;
        this.AR_productId = productId;
        this.AR_price = price;
        this.AR_quantity = quantity;
    }
    public string getname(){

        return AR_name;
    }

    public string getproductId(){

        return AR_productId;
    }

    public double getprice(){

        return AR_price * AR_quantity;
    }

    public int getquantity(){
        return  AR_quantity;
    }
}