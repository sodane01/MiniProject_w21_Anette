class SearchDevices
{
    public static void Search(List<Devices> devices)
    {
        Console.Write("Enter the type of device to search for: ");
        string searchType = Console.ReadLine();
        var results = devices.Where(d => d.type.Equals(searchType, StringComparison.OrdinalIgnoreCase)).ToList();
        if (results.Count > 0)
        {
            Console.WriteLine($"Found {results.Count} device(s) of type '{searchType}':");
            DisplayDevices.Display(results);
        }
        else
        {
            Console.WriteLine($"No devices found of type '{searchType}'.");
        }
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

