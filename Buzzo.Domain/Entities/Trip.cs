using Buzzo.Domain.Enums;

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

    private Trip()
    {
    }

    public Trip(
        Guid routeId,
        Guid busId,
        DateTime departureDateTime,
        DateTime arrivalDateTime,
        decimal baseFare,
        int availableSeats)
    {
        Id = Guid.NewGuid();
        RouteId = routeId;
        BusId = busId;
        DepartureDateTime = departureDateTime;
        ArrivalDateTime = arrivalDateTime;
        BaseFare = baseFare;
        AvailableSeats = availableSeats;
        Status = TripStatus.Scheduled;
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateSchedule(DateTime departure, DateTime arrival, decimal baseFare, TripStatus status)
    {
        DepartureDateTime = departure;
        ArrivalDateTime = arrival;
        BaseFare = baseFare;
        Status = status;
    }

    public void Cancel()
    {
        Status = TripStatus.Cancelled;
    }

    public void ReserveSeats(int count)
    {
        if (AvailableSeats < count)
            throw new InvalidOperationException("Not enough seats available.");
        AvailableSeats -= count;
    }

    public void ReleaseSeats(int count)
    {
        AvailableSeats += count;
    }

}