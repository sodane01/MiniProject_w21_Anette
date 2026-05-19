class Devices
{
    public string type;
    public string brand;
    public string model;
    public string purchaseDate;
    public Decimal priceUSD;
    public Decimal priceLocal;
    public string officeLocation;

    public Devices(string type, string brand, string model, string purchaseDate, decimal priceUSD, decimal priceLocal, string officeLocation)
    {
        this.type = type;
        this.brand = brand;
        this.model = model;
        this.purchaseDate = purchaseDate;
        this.priceUSD = priceUSD;
        this.priceLocal = priceLocal;
        this.officeLocation = officeLocation;
    }
}

