class CsvExporter : IDeviceExporter
{
    public void Export(List<Devices> devices, string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath);

        writer.WriteLine("Id,Type,Brand,Model,PurchaseDate,PriceUSD,PriceLocal,OfficeLocation");

        foreach (var device in devices)
        {
            writer.WriteLine($"{device.id},{device.type},{device.brand},{device.model},{device.purchaseDate},{device.priceUSD},{device.priceLocal},{device.officeLocation}");
        }
    }
}
