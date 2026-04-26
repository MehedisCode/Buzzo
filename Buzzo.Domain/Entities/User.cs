namespace Buzzo.Domain.Entities;

public class User
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string? Phone { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    public bool IsActive { get; private set; } = true;

    public ICollection<Booking> Bookings { get; private set; } = new List<Booking>();

    private User()
    {
    }

    public User(string firstName, string lastName, string? phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateProfile(string firstName, string lastName, string? phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        IsActive = false;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Activate()
    {
        IsActive = true;
        UpdatedAt = DateTime.UtcNow;
    }
}