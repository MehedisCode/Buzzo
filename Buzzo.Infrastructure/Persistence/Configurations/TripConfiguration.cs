using Buzzo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzzo.Infrastructure.Persistence.Configurations;

public class TripConfiguration : IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.BaseFare)
            .HasColumnType("decimal(10,2)");

        builder.Property(t => t.Status)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.HasMany(t => t.Bookings)
            .WithOne(b => b.Trip)
            .HasForeignKey(b => b.TripId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.Route)
            .WithMany(r => r.Trips)
            .HasForeignKey(t => t.RouteId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.Bus)
            .WithMany(b => b.Trips)
            .HasForeignKey(t => t.BusId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}