using Buzzo.Domain.Enums;

namespace Buzzo.Domain.Entities;

public class Passenger
{
    public Guid Id { get; private set; }
    public Guid BookingId { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public int Age { get; private set; }
    public Gender Gender { get; private set; }

    public Booking Booking { get; private set; } = null!;
    public ICollection<BookingSeat> BookingSeats { get; private set; } = new List<BookingSeat>();
}