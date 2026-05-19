class VerifyDevices
{
    public static void verifyDevices(List<Devices> devices)
    {
        if (devices.Count == 0)
        {
            Console.WriteLine("No devices found. Please add a device first.");
            return;
        }
    }

    public string verifyType(string type)
    {
        if (type != "Computer" && type != "Mobile")
        {
            Console.WriteLine("Invalid device type. Please enter 'Computer' or 'Mobile'.");
            return string.Empty;
        }
        return type;
    }
    public decimal verifyPrice(string priceInput)
    {
        if (!decimal.TryParse(priceInput, out decimal price))
        {
            Console.WriteLine("Invalid price format. Please enter a valid decimal number.");
            return -1;
        }
        return price;
    }
    public string verifyDate(string dateInput)
    {
        if (!DateTime.TryParse(dateInput, out DateTime purchaseDate))
        {
            Console.WriteLine("Invalid date format. Please enter a valid date (YYYY-MM-DD).");
            return string.Empty;
        }
        return purchaseDate.ToString("yyyy-MM-dd");
    }
    public string verifyOfficeLocation(string officeLocation)
    {
        if (officeLocation != "Sweden" && officeLocation != "Turkey" && officeLocation != "USA")
        {
            Console.WriteLine("Invalid office location. Please enter 'Sweden', 'Turkey', or 'USA'.");
            return string.Empty;
        }
        return officeLocation;
    }
}