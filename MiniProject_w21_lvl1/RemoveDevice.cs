
using System.Linq;

class RemoveDevice
{
    public void Remove(List<Devices> devices)
    {
        Console.Write("Enter ID of device to remove: ");
        string input = Console.ReadLine()?.Trim() ?? "";

        if (!int.TryParse(input, out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        var device = devices.FirstOrDefault(d => d.id == id);

        if (device == null)
        {
            Console.WriteLine("Device not found.");
            return;
        }

        devices.Remove(device);

        Console.WriteLine("Device removed successfully.");
    }
}