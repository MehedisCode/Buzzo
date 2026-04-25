namespace Buzzo.Domain.Entities;

public class Operator
{
    public Guid Id { get; private set; }
    public string CompanyName { get; private set; } = string.Empty;
    public string ContactEmail { get; private set; } = string.Empty;
    public string ContactPhone { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;
    public bool IsActive { get; private set; } = true;
    public DateTime CreatedAt { get; private set; }

    public ICollection<Bus> Buses { get; private set; } = new List<Bus>();
    public ICollection<Route> Routes { get; private set; } = new List<Route>();
}