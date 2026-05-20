class Currency
{
    public decimal convertToLocalCurrency(decimal value, string currency)
    {
        currency = currency.Trim().ToLower();

        return currency switch
        {
            "sweden" => value * 10.5m,
            "turkey" => value * 27.0m,
            "usa" => value,
            _ => throw new ArgumentException("Invalid office location")
        };
    }
}