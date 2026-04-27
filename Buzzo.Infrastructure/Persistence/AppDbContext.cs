using Microsoft.EntityFrameworkCore;
using Buzzo.Domain.Entities;

namespace Buzzo.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Operator> Operators { get; set; }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<BookingSeat> BookingSeats { get; set; }
    public DbSet<Passenger> Passengers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );
    }
}