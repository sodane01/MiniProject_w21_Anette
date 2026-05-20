class LoadDevices
{
    public static List<Devices> Load()
    {
        List<Devices> devices = new List<Devices>();
        string filePath = "devices.txt";

        if (!File.Exists(filePath))
        {
            return devices;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split('|');

            if (parts.Length != 7)
            {
                continue;
            }

            string type = parts[0];
            string brand = parts[1];
            string model = parts[2];
            string purchaseDate = parts[3];
            decimal priceUSD = decimal.Parse(parts[4]);
            decimal priceLocal = decimal.Parse(parts[5]);
            string officeLocation = parts[6];

            if (type == "Computer")
            {
                devices.Add(new Computer(type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation));
            }
            else if (type == "Mobile")
            {
                devices.Add(new Mobile(type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation));
            }
            else
            {
                devices.Add(new Devices(type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation));
            }
        }

        return devices;
    }
}