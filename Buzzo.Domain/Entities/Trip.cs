namespace Buzzo.Domain.Entities;

public class Trip
{
    public Guid Id { get; private set; }
    public Guid RouteId { get; private set; }
    public Guid BusId { get; private set; }
    public DateTime DepartureDateTime { get; private set; }
    public DateTime ArrivalDateTime { get; private set; }
    public decimal BaseFare { get; private set; }
    public int AvailableSeats { get; private set; }
    public TripStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Route Route { get; private set; } = null!;
    public Bus Bus { get; private set; } = null!;
    public ICollection<Booking> Bookings { get; private set; } = new List<Booking>();

}