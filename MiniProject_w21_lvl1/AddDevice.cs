class AddDevice
{

    public static void addDevice()
    {
        VerifyDevices verify = new VerifyDevices();

        List<Devices> addedDevicesList = new List<Devices>();

        Console.WriteLine();
        Console.WriteLine("Choose type of device to add:");
        Console.WriteLine("1. Computer");
        Console.WriteLine("2. Mobile");

        int choice = int.Parse(Console.ReadLine());
        string type = choice == 1 ? "Computer" : "Mobile";

        Console.WriteLine("Enter device brand (e.g., Dell, Apple): ");
        string brand = Console.ReadLine()?.Trim() ?? string.Empty; ;

        Console.WriteLine("Enter device model (e.g., XPS 13, iPhone 13): ");
        string model = Console.ReadLine()?.Trim() ?? string.Empty;

        Console.WriteLine("Enter purchase date (YYYY-MM-DD): ");
        string purchaseDate = Console.ReadLine()?.Trim() ?? string.Empty;
        purchaseDate = verify.verifyDate(purchaseDate);

        Console.WriteLine("Enter office location, Sweden, Turkey or USA: ");
        string officeLocation = Console.ReadLine()?.Trim() ?? string.Empty;
        officeLocation = verify.verifyOfficeLocation(officeLocation);

        if(officeLocation.Equals("gothenburg",
    StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter price in SEK: ");
            decimal priceSEK = decimal.Parse(Console.ReadLine());
        }
        else if(officeLocation.Equals("istanbul", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter price in TRY: ");
            decimal priceTRY = decimal.Parse(Console.ReadLine());
        }
        else if(officeLocation.Equals("new york", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter price in USD: ");
            decimal priceUSD = decimal.Parse(Console.ReadLine());
        }
      
        Console.WriteLine("Enter price in local currency: ");
        decimal priceLocal = decimal.Parse(Console.ReadLine());

        Devices newDevice = new Devices(type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation);
        addedDevicesList.Add(newDevice);
        Console.WriteLine("Device added successfully!");
        
    }

}