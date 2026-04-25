namespace Buzzo.Domain.Entities;

public class Booking
{
    public Guid Id { get; private set; }
    public string BookingNumber { get; private set; } = string.Empty;
    public string UserId { get; private set; } = string.Empty;
    public Guid TripId { get; private set; }
    public DateTime BookingDate { get; private set; }
    public decimal TotalAmount { get; private set; }
    public BookingStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    public User User { get; private set; } = null!;
    public Trip Trip { get; private set; } = null!;
    public ICollection<BookingSeat> BookingSeats { get; private set; } = new List<BookingSeat>();
    public ICollection<Passenger> Passengers { get; private set; } = new List<Passenger>();
}