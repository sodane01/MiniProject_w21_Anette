class EndOfLife()
{
    public static void CheckEndOfLife(List<Devices> devices)
    {
        Console.WriteLine("Devices that are at the end of their life cycle:");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
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
        foreach (var device in devices.Where(d => IsEndOfLife(d)))
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
    private static bool IsEndOfLife(Devices device)
    {
        DateTime purchaseDate = DateTime.Parse(device.purchaseDate);
        return (DateTime.Now - purchaseDate).TotalDays > 365 * 3; // Assuming a device is at end of life after 3 years
    }
}


//switch (input)
//{
//    case 1:
//        AddDevice();
//        break;

//    case 2:
//        DisplayDevices(devices);
//        break;
//    case 3:
//        Sort();
//        break; 
//    case 4:
//        SearchDevices(devices);
//        break;
//    case 5:
//        Environment.Exit(0);
//        break;
//}

