class ValidateDevices
{
    public static void verifyDevices(List<Devices> devices)
    {
        if (devices.Count == 0)
        {
            Console.WriteLine("No devices found. Please add a device first.");
            return;
        }
    }

    //public string verifyType(string type)
    //{
    //    if (type != "Computer" && type != "Mobile")
    //    {
    //        Console.WriteLine("Invalid device type. Please enter 'Computer' or 'Mobile'.");
    //        return string.Empty;
    //    }
    //    return type;
    //}

    public int validateId(string idInput, List<Devices> devices)
    {
        while (true)
        {
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid ID format. Please enter a valid integer.");
            }
            else if (devices.Any(d => d.id == id))
            {
                Console.WriteLine("This ID already exists.");
            }
            else
            {
                return id;
            }

            Console.Write("Enter another ID: ");
            idInput = Console.ReadLine()?.Trim() ?? "";
        }
    }
    public int validateChoice(string choiceInput)
    {
        if (!int.TryParse(choiceInput, out int choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice. Please enter 1 for Computer or 2 for Mobile.");
            return -1;
        }
        return choice;
    }

    public decimal validatePrice(string priceInput)
    {
        if (!decimal.TryParse(priceInput, out decimal price))
        {
            Console.WriteLine("Invalid price format. Please enter a valid decimal number.");
            return -1;
        }
        return price;
    }
    public string validateDate(string dateInput)
    {
        if (!DateTime.TryParse(dateInput, out DateTime purchaseDate))
        {
            Console.WriteLine("Invalid date format. Please enter a valid date (YYYY-MM-DD).");
            return string.Empty;
        }
        return purchaseDate.ToString("yyyy-MM-dd");
    }
    public string validateOfficeLocation(string officeLocation)
    {
        while (true)
        {
            if (officeLocation.Equals("Sweden", StringComparison.OrdinalIgnoreCase))
            {
                return "Sweden";
            }

            if (officeLocation.Equals("Turkey", StringComparison.OrdinalIgnoreCase))
            {
                return "Turkey";
            }

            if (officeLocation.Equals("USA", StringComparison.OrdinalIgnoreCase))
            {
                return "USA";
            }

            Console.WriteLine("Invalid office location. Enter Sweden, Turkey or USA:");

            officeLocation = Console.ReadLine()?.Trim() ?? "";
        }
    }
    public string validateBrand(string brand)
    {
        if (string.IsNullOrWhiteSpace(brand))
        {
            Console.WriteLine("Brand cannot be empty. Please enter a valid brand.");
            return string.Empty;
        }
        return brand;
    }
    public string validateModel(string model)
    {
        if (string.IsNullOrWhiteSpace(model))
        {
            Console.WriteLine("Model cannot be empty. Please enter a valid model.");
            return string.Empty;
        }
        return model;
    }
}