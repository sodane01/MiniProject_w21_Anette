class Currency
{
    public decimal convertToLocalCurrency(decimal value, string currency)
    {

        return currency switch
        {
            "Sweden" => value * 10.5m, // Example conversion rate for SEK
            "Turkey" => value * 27.0m,   // Example conversion rate for TRY
            "USA" => value,              // USD remains the same
            _ => throw new ArgumentException("Invalid office location")
        };
    }
}
