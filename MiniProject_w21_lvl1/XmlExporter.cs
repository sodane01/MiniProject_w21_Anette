using System.Xml.Serialization;

class XmlExporter : IDeviceExporter
{
    public void Export(List<Devices> devices, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Devices>));

        using FileStream stream = new FileStream(filePath, FileMode.Create);

        serializer.Serialize(stream, devices);
    }
}