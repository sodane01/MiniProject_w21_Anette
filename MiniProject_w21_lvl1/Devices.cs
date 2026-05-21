
using System.Xml.Serialization;

[XmlInclude(typeof(Computer))]
[XmlInclude(typeof(Mobile))]
public class Devices
{
    public int id { get; set; }
    public string type { get; set; }
    public string brand { get; set; }
    public string model { get; set; }
    public string purchaseDate { get; set; }
    public decimal priceUSD { get; set; }
    public decimal priceLocal { get; set; }
    public string officeLocation { get; set; }

    public Devices()
    {
    }

    public Devices(int id, string type, string brand, string model, string purchaseDate,
        decimal priceUSD, decimal priceLocal, string officeLocation)
    {
        this.id = id;
        this.type = type;
        this.brand = brand;
        this.model = model;
        this.purchaseDate = purchaseDate;
        this.priceUSD = priceUSD;
        this.priceLocal = priceLocal;
        this.officeLocation = officeLocation;
    }
}