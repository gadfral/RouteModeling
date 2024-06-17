namespace RouteModelingCore.Entities;

public sealed class Valuation
{
    public bool AvailabilityOfInsurance { get; set; }

    public decimal CostOfInsurance { get; set; }

    public decimal CoveredAmount { get; set; }
}