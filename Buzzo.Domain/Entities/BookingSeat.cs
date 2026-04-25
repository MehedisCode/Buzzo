public class BookingSeat
{
    public Guid Id { get; private set; }
    public Guid BookingId { get; private set; }
    public Guid SeatId { get; private set; }
    public Guid PassengerId { get; private set; }

    public Booking Booking { get; private set; } = null!;
    public Seat Seat { get; private set; } = null!;
    public Passenger Passenger { get; private set; } = null!;
}