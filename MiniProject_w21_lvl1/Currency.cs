class Currency
{
    public static decimal ConvertToLocalCurrency(decimal priceUSD, decimal exchangeRate)
    {
        return priceUSD * exchangeRate;
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

