using Buzzo.Domain.Enums;

namespace Buzzo.Domain.Entities;

public class Bus
{
    public Guid Id { get; private set; }
    public Guid OperatorId { get; private set; }
    public string BusNumber { get; private set; } = string.Empty;
    public string BusName { get; private set; } = string.Empty;
    public int TotalSeats { get; private set; }
    public BusType BusType { get; private set; }
    public bool IsActive { get; private set; } = true;
    public DateTime CreatedAt { get; private set; }

    public Operator Operator { get; private set; } = null!;
    public ICollection<Seat> Seats { get; private set; } = new List<Seat>();
    public ICollection<Trip> Trips { get; private set; } = new List<Trip>();

    private Bus()
    {
    }

    public Bus
    (
        Guid operatorId,
        string busNumber,
        string busName,
        int totalSeats,
        BusType busType
    )
    {
        Id = Guid.NewGuid();
        OperatorId = operatorId;
        BusNumber = busNumber;
        BusName = busName;
        TotalSeats = totalSeats;
        BusType = busType;
        CreatedAt = DateTime.UtcNow;
    }
}