namespace Buzzo.Domain.Entities;

public class Route
{
    public Guid Id { get; private set; }
    public Guid OperatorId { get; private set; }
    public string OriginCity { get; private set; } = string.Empty;
    public string DestinationCity { get; private set; } = string.Empty;
    public decimal TotalDistanceKm { get; private set; }
    public bool IsActive { get; private set; } = true;

    public Operator Operator { get; private set; } = null!;
    public ICollection<Trip> Trips { get; private set; } = new List<Trip>();
}