class Offices : Devices
{
    public string officeLocation;
    public Offices(int id, string type, string brand, string model, string purchaseDate, decimal priceUSD, decimal priceLocal, string officeLocation)
        : base(id, type, brand, model, purchaseDate, priceUSD, priceLocal, officeLocation)
    {
        this.officeLocation = officeLocation;
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

