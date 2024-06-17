namespace RouteModelingApp.Entities;

public class RouteModel
{
    public string СurrencyCode { get; set; }

    public decimal FullPrice { get; set; }

    /// <summary>
    /// Время минутах
    /// </summary>
    public double Time { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}