class AddDevice
{
    
    public List<Devices> addDevice(List<Devices> devices)
    {
        VerifyDevices verify = new VerifyDevices();

        List<Devices> newDevices = new List<Devices>();

        Currency converter = new Currency();


        Console.WriteLine();
        Console.WriteLine("Choose type of device to add:");
        Console.WriteLine("1. Computer");
        Console.WriteLine("2. Mobile");

        int choice = int.Parse(Console.ReadLine());
        string type = choice == 1 ? "Computer" : "Mobile";
        choice = verify.verifyChoice(choice.ToString());

        Console.WriteLine("Add id number:");
        int id = int.Parse(Console.ReadLine());
        id = verify.VerifyId(id.ToString(), devices);

        Console.WriteLine("Enter device brand (e.g., Dell, Apple): ");
        string brand = Console.ReadLine()?.Trim() ?? string.Empty;
        brand = verify.verifyBrand(brand);

        Console.WriteLine("Enter device model (e.g., XPS 13, iPhone 13): ");
        string model = Console.ReadLine()?.Trim() ?? string.Empty;
        model = verify.verifyModel(model);

        Console.WriteLine("Enter purchase date (YYYY-MM-DD): ");
        string purchaseDate = Console.ReadLine()?.Trim() ?? string.Empty;
        purchaseDate = verify.verifyDate(purchaseDate);

        Console.WriteLine("Enter office location, Sweden, Turkey or USA: ");
        string officeLocation = Console.ReadLine()?.Trim() ?? string.Empty;
        officeLocation = verify.verifyOfficeLocation(officeLocation);

        Console.WriteLine("Enter price in USD: ");
        decimal priceUSD = decimal.Parse(Console.ReadLine());
        priceUSD = verify.verifyPrice(priceUSD.ToString());
        decimal localPrice = converter.convertToLocalCurrency(priceUSD, officeLocation);
        newDevices.Add(new Devices(id, type, brand, model, purchaseDate, priceUSD, localPrice, officeLocation));
        //newDevices.Add(new Devices(type, brand, model, purchaseDate, priceUSD, localPrice, officeLocation));



        //Devices newDevice = new Devices(type, brand, model, purchaseDate, priceUSD, localPrice, officeLocation);
        //devices.Add(newDevice);
        Console.WriteLine("Device added successfully!");
        return newDevices;
        
    }

}

//if(officeLocation.Equals("gothenburg",
//StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("Enter price in SEK: ");
//    decimal priceSEK = decimal.Parse(Console.ReadLine());
//    converter.ConvertToUSD(priceSEK, "SEK");
//}
//else if(officeLocation.Equals("istanbul", StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("Enter price in TRY: ");
//    decimal priceTRY = decimal.Parse(Console.ReadLine());
//    converter.ConvertToUSD(priceTRY, "TRY");
//}
//else if(officeLocation.Equals("new york", StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("Enter price in USD: ");
//    decimal priceUSD = decimal.Parse(Console.ReadLine());
//}