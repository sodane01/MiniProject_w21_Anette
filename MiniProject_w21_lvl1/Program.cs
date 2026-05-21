using System.Linq;

List<Devices> devices = new List<Devices>();
//devices.Add(new Computer("Laptop", "Dell", "XPS 13", "2022-01-15", 1200.00m, 1500.00m, "New York"));
//devices.Add(new Mobile("Smartphone", "Apple", "iPhone 13", "2022-02-20", 999.00m, 1249.00m, "Los Angeles"));
//devices.Add(new Computer("Desktop", "HP", "Pavilion", "2021-11-10", 800.00m, 1000.00m, "Chicago"));
//devices.Add(new Mobile("Tablet", "Samsung", "Galaxy Tab S7", "2022-03-05", 650.00m, 850.00m, "Houston"));
//devices.Add(new Computer("Laptop", "Lenovo", "ThinkPad X1 Carbon", "2022-04-12", 1400.00m, 1750.00m, "San Francisco"));
//devices.Add(new Mobile("Smartphone", "Google", "Pixel 6", "2022-05-18", 599.00m, 749.00m, "Seattle"));
//devices.Add(new Computer("Desktop", "Apple", "iMac", "2021-12-01", 1800.00m, 2250.00m, "Miami"));

//SortDevices sort = new SortDevices();
devices = LoadDevices.Load();
bool running = true;

while(running)
{
    int input;
    Console.WriteLine("**************************************");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("COMPANY DEVICE TRACKING SYSTEM");
    Console.ResetColor();
    Console.WriteLine("**************************************");
    Console.WriteLine();
    Console.WriteLine("1. Add device");
    Console.WriteLine("2. Display devices");
    Console.WriteLine("3. Sort devices");
    Console.WriteLine("4. Search devices");
    Console.WriteLine("5. Export to file");
    Console.WriteLine("6. Exit");
    Console.WriteLine();

    Console.Write("Enter your choice: ");
    input = int.Parse(Console.ReadLine());

    {
        switch (input)
        {
            case 1:
                AddDevice add = new AddDevice();
                List<Devices> newDevices = add.AddDevices(devices);
                devices.AddRange(newDevices);
                SaveDevices.Save(devices);
                break;


            case 2:
                DisplayDevices display = new DisplayDevices();
                display.displayDevices(devices);
                break;
            case 3:
                Console.WriteLine("Sorting selected...");
                SortDevices.sortDevices(devices);
                break;
            case 4:
                //SearchDevices(devices);
                break;
            case 5:
            //ExportToCSV export = new ExportToCSV();
            //export.Export(devices);
            //break;

                Console.WriteLine("Choose export format:");
                Console.WriteLine("1. CSV");
                Console.WriteLine("2. JSON");
                Console.WriteLine("3. XML");

                string exportChoice = Console.ReadLine()?.Trim() ?? "";

                IDeviceExporter? exporter = null;

                switch (exportChoice)
                {
                    case "1":
                        exporter = new CsvExporter();
                        break;

                    case "2":
                        exporter = new JsonExporter();
                        break;

                    case "3":
                        exporter = new XmlExporter();
                        break;

                    default:
                        Console.WriteLine("Invalid export choice.");
                        break;
                }

                if (exporter != null)
                {
                    Console.Write("Enter file name: ");

                    string fileName =
                        Console.ReadLine()?.Trim() ?? "devices";

                    exporter.Export(devices, fileName);
                }

                break;
            case 6:
                Console.WriteLine("Exiting the program...");
                running = false;
                break;
        }
    }
}
interface IDeviceExporter
{
    void Export(List<Devices> devices, string filePath);
}

