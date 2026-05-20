//class DisplayDevices
//{
//    public void displayDevices(List<Devices> devices)
//    {
//        Console.WriteLine();
//Console.WriteLine("-------------------------------------------------------------------------------------");

//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine(

//    $"{"Type",-15}" +
//    $"{"Brand",-15}" +
//    $"{"Model",-25}" +
//    $"{"Purchase Date",-20:yyyy-MM-dd}" +
//    $"{"Price (USD)",-15:C}" +
//    $"{"Price (Local)",-15:C}" +
//    $"{"Office Location",-20}");

//Console.ResetColor();

//Console.WriteLine("-------------------------------------------------------------------------------------");

//foreach (var device in devices.OrderBy(d => d.type))
//{
//    Console.WriteLine(
//        $"{device.type,-15}" +
//        $"{device.brand,-15}" +
//        $"{device.model,-25}" +
//        $"{device.purchaseDate,-20:yyyy-MM-dd}" +
//        $"{device.priceUSD,-150}" +
//        $"{device.priceLocal,-15}" +
//        $"{device.officeLocation,-20}");
//}


//Console.WriteLine("-------------------------------------------------------------------------------------");
//    }
//}

class DisplayDevices
{
    public void displayDevices(List<Devices> devices)
    {
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(
            $"{"Id",-5} " +
            $"{"Type",-15} " +
            $"{"Brand",-15} " +
            $"{"Model",-25} " +
            $"{"Purchase Date",-10} " +
            $"{"Price USD",15} " +
            $"{"Local Price",20} " +
            $"{"Office Location",20}");

        Console.ResetColor();

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");

        foreach (var device in devices.OrderBy(d => d.type))
        {
            DateTime purchaseDate = DateTime.Parse(device.purchaseDate);
            DateTime endOfLifeDate = purchaseDate.AddYears(3);

            TimeSpan timeLeft = endOfLifeDate - DateTime.Today;

            if (timeLeft.TotalDays < 90)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (timeLeft.TotalDays < 180)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.WriteLine(
                $"{device.id,-5} " +
                $"{device.type,-15} " +
                $"{device.brand,-15} " +
                $"{device.model,-25} " +
                $"{device.purchaseDate,-10} " +
                $"{device.priceUSD,15} " +
                $"{device.priceLocal,20} " +
                $"{device.officeLocation,20}");

            Console.ResetColor();
        }
        Console.WriteLine();
        Console.WriteLine();

        //Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

    }
}