class Address{

    private string AR_street;
    private string AR_city;
    private string AR_state;
    private string AR_country;

    public Address(string street, string city, string state, string country){

        this.AR_street = street;
        this.AR_city = city;
        this.AR_state = state;
        this.AR_country = country;

    }

    public bool intheUSA(){

        return AR_country=="USA";
    }

    public string fulladdress(){

        return $"{AR_street}\n {AR_city}, {AR_state} {AR_country}";
    }
}