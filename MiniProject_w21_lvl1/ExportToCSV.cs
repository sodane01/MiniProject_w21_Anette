class ExportToCSV
{
    public void Export(List<Devices> devices)
    {
        string filePath = Path.GetFullPath("devices.csv");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Id,Type,Brand,Model,PurchaseDate,PriceUSD,PriceLocal,OfficeLocation");

            foreach (var device in devices)
            {
                writer.WriteLine(
                    $"{device.id}," +
                    $"{device.type}," +
                    $"{device.brand}," +
                    $"{device.model}," +
                    $"{device.purchaseDate}," +
                    $"{device.priceUSD}," +
                    $"{device.priceLocal}," +
                    $"{device.officeLocation}");
            }
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Devices exported successfully!");
        Console.ResetColor();

        Console.WriteLine($"File saved to:");
        Console.WriteLine(filePath);
    }
}