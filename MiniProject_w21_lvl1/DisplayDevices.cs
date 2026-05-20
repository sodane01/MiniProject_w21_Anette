class DisplayDevices
{
    public void displayDevices(List<Devices> devices)
    {
        Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------------------------");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(

    $"{"Type",-15}" +
    $"{"Brand",-15}" +
    $"{"Model",-25}" +
    $"{"Purchase Date",-20:yyyy-MM-dd}" +
    $"{"Price (USD)",-15:C}" +
    $"{"Price (Local)",-15:C}" +
    $"{"Office Location",-20}");

Console.ResetColor();

Console.WriteLine("-------------------------------------------------------------------------------------");

foreach (var device in devices.OrderBy(d => d.type))
{
    Console.WriteLine(
        $"{device.type,-15}" +
        $"{device.brand,-15}" +
        $"{device.model,-25}" +
        $"{device.purchaseDate,-20:yyyy-MM-dd}" +
        $"{device.priceUSD,-150}" +
        $"{device.priceLocal,-15}" +
        $"{device.officeLocation,-20}");
}


Console.WriteLine("-------------------------------------------------------------------------------------");
    }
}

