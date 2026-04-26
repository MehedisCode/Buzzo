namespace Buzzo.Domain.Entities;

public class Route
{
    public Guid Id { get; private set; }
    public Guid OperatorId { get; private set; }
    public string OriginCity { get; private set; } = string.Empty;
    public string DestinationCity { get; private set; } = string.Empty;
    public string OriginTerminal { get; private set; } = string.Empty;
    public string DestinationTerminal { get; private set; } = string.Empty;
    public decimal TotalDistanceKm { get; private set; }
    public bool IsActive { get; private set; } = true;

    public Operator Operator { get; private set; } = null!;
    public ICollection<Trip> Trips { get; private set; } = new List<Trip>();

    private Route()
    {
    }

    public Route
    (
        Guid operatorId,
        string originCity,
        string destinationCity,
        string originTerminal,
        string destinationTerminal,
        decimal totalDistanceKm
    )
    {
        Id = Guid.NewGuid();
        OperatorId = operatorId;
        OriginCity = originCity;
        DestinationCity = destinationCity;
        OriginTerminal = originTerminal;
        DestinationTerminal = destinationTerminal;
        TotalDistanceKm = totalDistanceKm;
    }

    public void Update
    (
        string originCity,
        string destinationCity,
        string originTerminal,
        string destinationTerminal,
        decimal totalDistanceKm,
        bool isActive
    )
    {
        OriginCity = originCity;
        DestinationCity = destinationCity;
        OriginTerminal = originTerminal;
        DestinationTerminal = destinationTerminal;
        TotalDistanceKm = totalDistanceKm;
        IsActive = isActive;
    }
}