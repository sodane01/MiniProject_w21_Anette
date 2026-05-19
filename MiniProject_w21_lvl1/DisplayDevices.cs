class DisplayDevices
{
    public static void Display(List<Devices> devices)
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
        $"{device.priceUSD,-15:C}" +
        $"{device.priceLocal,-15:C}" +
        $"{device.officeLocation,-20}");
}


Console.WriteLine("-------------------------------------------------------------------------------------");
    }
}

