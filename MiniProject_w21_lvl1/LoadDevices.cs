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

            if (parts.Length != 8)
            {
                continue;
            }

            int id = int.Parse(parts[0]);
            string type = parts[1];
            string brand = parts[2];
            string model = parts[3];
            string purchaseDate = parts[4];
            decimal priceUSD = decimal.Parse(parts[5]);
            decimal priceLocal = decimal.Parse(parts[6]);
            string officeLocation = parts[7];

            if (type == "Computer")
            {
                devices.Add(new Computer(id, type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation));
            }
            else if (type == "Mobile")
            {
                devices.Add(new Mobile(id, type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation));
            }
            else
            {
                devices.Add(new Devices(id, type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation));
            }
        }

        return devices;
    }
}