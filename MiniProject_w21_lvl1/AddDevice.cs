//class AddDevice
//{

    //public List<Devices> addDevice(List<Devices> devices)
    //{
    //    ValidateDevices verify = new ValidateDevices();

    //    List<Devices> newDevices = new List<Devices>();

    //    Currency converter = new Currency();


    //    Console.WriteLine();
    //    Console.WriteLine("Choose type of device to add:");
    //    Console.WriteLine("1. Computer");
    //    Console.WriteLine("2. Mobile");

    //    int choice = int.Parse(Console.ReadLine());
    //    string type = choice == 1 ? "Computer" : "Mobile";
    //    choice = verify.validateChoice(choice.ToString());

    //    Console.WriteLine("Add id number:");
    //    string idInput = Console.ReadLine()?.Trim() ?? "";
    //    int id = verify.validateId(idInput, devices);

    //    Console.WriteLine("Enter device brand (e.g., Dell, Apple): ");
    //    string brand = Console.ReadLine()?.Trim() ?? string.Empty;
    //    brand = verify.validateBrand(brand);

    //    Console.WriteLine("Enter device model (e.g., XPS 13, iPhone 13): ");
    //    string model = Console.ReadLine()?.Trim() ?? string.Empty;
    //    model = verify.validateModel(model);

    //    Console.WriteLine("Enter purchase date (YYYY-MM-DD): ");
    //    string purchaseDate = Console.ReadLine()?.Trim() ?? string.Empty;
    //    purchaseDate = verify.validateDate(purchaseDate);

    //    Console.WriteLine("Enter office location, Sweden, Turkey or USA: ");
    //    string officeLocation = Console.ReadLine()?.Trim() ?? string.Empty;
    //    officeLocation = verify.validateOfficeLocation(officeLocation);

    //    Console.WriteLine("Enter price in USD: ");
    //    decimal priceUSD = decimal.Parse(Console.ReadLine());
    //    priceUSD = verify.validatePrice(priceUSD.ToString());
    //    decimal localPrice = converter.convertToLocalCurrency(priceUSD, officeLocation);
    //    newDevices.Add(new Devices(id, type, brand, model, purchaseDate, priceUSD, localPrice, officeLocation));
    //    //newDevices.Add(new Devices(type, brand, model, purchaseDate, priceUSD, localPrice, officeLocation));



    //    //Devices newDevice = new Devices(type, brand, model, purchaseDate, priceUSD, localPrice, officeLocation);
    //    //devices.Add(newDevice);
    //    Console.WriteLine("Device added successfully!");
    //    return newDevices;

    //}

    class AddDevice
    {
        private readonly ValidateDevices verify = new();
        private readonly Currency converter = new();

        public List<Devices> AddDevices(List<Devices> devices)
        {
            List<Devices> newDevices = new();

            string type = AskForDeviceType();
            int id = AskForId(devices);
            string brand = AskForBrand();
            string model = AskForModel();
            string purchaseDate = AskForPurchaseDate();
            string officeLocation = AskForOfficeLocation();
            decimal priceUSD = AskForPrice();

            decimal localPrice = converter.convertToLocalCurrency(priceUSD, officeLocation);

            newDevices.Add(new Devices(
                id,
                type,
                brand,
                model,
                purchaseDate,
                priceUSD,
                localPrice,
                officeLocation));

            Console.WriteLine("Device added successfully!");

            return newDevices;
        }

        private string AskForDeviceType()
        {
            Console.WriteLine();
            Console.WriteLine("Choose type of device to add:");
            Console.WriteLine("1. Computer");
            Console.WriteLine("2. Mobile");

            string choiceInput = Console.ReadLine()?.Trim() ?? "";
            int choice = verify.ValidateChoice(choiceInput);

            return choice == 1 ? "Computer" : "Mobile";
        }

        private int AskForId(List<Devices> devices)
        {
            Console.WriteLine("Add id number:");
            string idInput = Console.ReadLine()?.Trim() ?? "";

            return verify.ValidateId(idInput, devices);
        }

        private string AskForBrand()
        {
            Console.WriteLine("Enter device brand (e.g., Dell, Apple): ");
            string brand = Console.ReadLine()?.Trim() ?? "";

            return verify.ValidateBrand(brand);
        }

        private string AskForModel()
        {
            Console.WriteLine("Enter device model (e.g., XPS 13, iPhone 13): ");
            string model = Console.ReadLine()?.Trim() ?? "";

            return verify.ValidateModel(model);
        }

        private string AskForPurchaseDate()
        {
            Console.WriteLine("Enter purchase date (YYYY-MM-DD): ");
            string purchaseDate = Console.ReadLine()?.Trim() ?? "";

            return verify.ValidateDate(purchaseDate);
        }

        private string AskForOfficeLocation()
        {
            Console.WriteLine("Enter office location, Sweden, Turkey or USA: ");
            string officeLocation = Console.ReadLine()?.Trim() ?? "";

            return verify.ValidateOfficeLocation(officeLocation);
        }

        private decimal AskForPrice()
        {
            Console.WriteLine("Enter price in USD: ");
            string priceInput = Console.ReadLine()?.Trim() ?? "";

            return verify.ValidatePrice(priceInput);
        }
    }

//}

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