namespace RouteModelingCore.Entities;

public sealed class Valuation
{
    public decimal Price { get; set; }

    public decimal Tax { get; set; }

    public string СurrencyCode { get; set; }

    public decimal FullPrice { get; set; }

    public bool AvailabilityOfInsurance { get; set; }

    public decimal CostOfInsurance { get; set; }

    public decimal CoveredAmount { get; set; }
}