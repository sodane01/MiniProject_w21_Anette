using System.Linq;
class SortDevices
{
    public static void sortDevices(List<Devices> devices)
    {
        Console.WriteLine("DEBUG: NEW SORT METHOD IS RUNNING");
        Console.WriteLine("DEBUG: sortDevices started");
        Console.WriteLine($"DEBUG: devices count = {devices.Count}");

        if (devices.Count == 0)
        {
            Console.WriteLine("No devices available.");
            return;
        }

        Console.WriteLine("\nSort devices by:");
        Console.WriteLine("1. Id");
        Console.WriteLine("2. Type");
        Console.WriteLine("3. Brand");
        Console.WriteLine("4. Model");
        Console.WriteLine("5. Purchase Date");
        Console.WriteLine("6. Price USD");
        Console.WriteLine("7. Local Price");
        Console.WriteLine("8. Office Location");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine()?.Trim() ?? "";

        Console.WriteLine($"DEBUG: sort choice = {choice}");

        Console.WriteLine("\nChoose sorting order:");
        Console.WriteLine("1. Ascending");
        Console.WriteLine("2. Descending");

        Console.Write("Enter your choice: ");
        string orderChoice = Console.ReadLine()?.Trim() ?? "";

        Console.WriteLine($"DEBUG: order choice = {orderChoice}");

        if (orderChoice != "1" && orderChoice != "2")
        {
            Console.WriteLine("Invalid sorting order.");
            return;
        }

        bool ascending = orderChoice == "1";

        List<Devices> sortedDevices;

        switch (choice)
        {
            case "1":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.id).ToList()
                    : devices.OrderByDescending(d => d.id).ToList();
                break;

            case "2":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.type).ToList()
                    : devices.OrderByDescending(d => d.type).ToList();
                break;

            case "3":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.brand).ToList()
                    : devices.OrderByDescending(d => d.brand).ToList();
                break;

            case "4":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.model).ToList()
                    : devices.OrderByDescending(d => d.model).ToList();
                break;

            case "5":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.purchaseDate).ToList()
                    : devices.OrderByDescending(d => d.purchaseDate).ToList();
                break;

            case "6":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.priceUSD).ToList()
                    : devices.OrderByDescending(d => d.priceUSD).ToList();
                break;

            case "7":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.priceLocal).ToList()
                    : devices.OrderByDescending(d => d.priceLocal).ToList();
                break;

            case "8":
                sortedDevices = ascending
                    ? devices.OrderBy(d => d.officeLocation).ToList()
                    : devices.OrderByDescending(d => d.officeLocation).ToList();
                break;

            default:
                Console.WriteLine("Invalid sort choice.");
                return;
        }

        Console.WriteLine("\nSorted devices:");

        DisplayDevices display = new DisplayDevices();
        display.displayDevices(sortedDevices);
    }
}