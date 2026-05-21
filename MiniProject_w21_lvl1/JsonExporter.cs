using System.Text.Json;

class JsonExporter : IDeviceExporter
{
    public void Export(List<Devices> devices, string filePath)
    {
        string json = JsonSerializer.Serialize(devices, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, json);
    }
}