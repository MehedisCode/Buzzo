namespace Buzzo.Domain.Entities;

public class Seat
{
    public Guid Id { get; private set; }
    public Guid BusId { get; private set; }
    public string SeatNumber { get; private set; } = string.Empty;
    public bool IsActive { get; private set; } = true;

    public Bus Bus { get; private set; } = null!;
    public ICollection<BookingSeat> BookingSeats { get; private set; } = new List<BookingSeat>();

}