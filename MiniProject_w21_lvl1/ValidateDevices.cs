class ValidateDevices
{
    public static void validateDevices(List<Devices> devices)
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

    public int ValidateId(string idInput, List<Devices> devices)
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
    public int ValidateChoice(string choiceInput)
    {
        if (!int.TryParse(choiceInput, out int choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice. Please enter 1 for Computer or 2 for Mobile.");
            return -1;
        }
        return choice;
    }

    public decimal ValidatePrice(string input)
    {
        while (true)
        {
            if (decimal.TryParse(input, out decimal price) &&
                price > 0)
            {
                return price;
            }

            Console.WriteLine("Invalid price.");

            Console.Write("Enter price again: ");

            input = Console.ReadLine()?.Trim() ?? "";
        }
    }
    public string ValidateDate(string dateInput)
    {
        while (true)
        {
            if (string.IsNullOrEmpty(dateInput))
            {
                Console.WriteLine("Date cannot be empty.");
            }
            else if (DateTime.TryParse(dateInput, out DateTime purchaseDate))
            {
                return purchaseDate.ToString("yyyy-MM-dd");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (YYYY-MM-DD).");
            }

            Console.Write("Enter purchase date again: ");
            Console.WriteLine();
            dateInput = Console.ReadLine()?.Trim() ?? "";
        }
    }
    public string ValidateOfficeLocation(string officeLocation)
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
    public string ValidateBrand(string brand)
    {
        while (true)
        {
            if (!string.IsNullOrWhiteSpace(brand))
            {
                return brand;
            }

            Console.WriteLine("Brand cannot be empty.");

            Console.Write("Enter brand again: ");

            brand = Console.ReadLine()?.Trim() ?? "";
        }
    }
    public string ValidateModel(string model)
    {
        while (true)
        {
            if (!string.IsNullOrWhiteSpace(model))
            {
                return model;
            }

            Console.WriteLine("Model cannot be empty.");

            Console.Write("Enter model again: ");

            model = Console.ReadLine()?.Trim() ?? "";
        }
    }

}