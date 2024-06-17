namespace RouteModelingApp.Entities;

public class RouteModel
{
    public string СurrencyCode { get; set; }

    public string FullPrice { get; set; }

    /// <summary>
    /// Время минутах
    /// </summary>
    public string Time { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}