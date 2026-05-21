public class Mobile : Devices
{

    public Mobile()
    {
    }
    public Mobile(int id, string type, string brand, string model, string purchaseDate, decimal priceUSD, decimal priceLocal, string officeLocation) : base(id, type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation)
    {
    }
}

