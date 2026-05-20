class SaveDevices
{
    public static void Save(List<Devices> devices)
    {
        string filePath = "devices.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var device in devices)
            {
                writer.WriteLine($"{device.type}|{device.brand}|{device.model}|{device.purchaseDate}|{device.priceUSD}|{device.priceLocal}|{device.officeLocation}");
            }
        }
    }
}