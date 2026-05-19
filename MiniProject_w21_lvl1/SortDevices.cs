class SortDevices
{
    List<Devices> sortedList = new();
    public static void sortDevices(List<Devices> devices)
    {
        var sortedDevices = devices.OrderBy(d => d.type).ThenBy(d => d.brand).ToList();
        DisplayDevices.Display(sortedDevices);
    }
}


