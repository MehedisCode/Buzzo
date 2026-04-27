using Buzzo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buzzo.Infrastructure.Persistence.Configurations;

public class BookingSeatConfiguration : IEntityTypeConfiguration<BookingSeat>
{
    public void Configure(EntityTypeBuilder<BookingSeat> builder)
    {
        builder.HasKey(b => b.Id);

        builder.HasOne(bs => bs.Passenger)
            .WithMany(p => p.BookingSeats)
            .HasForeignKey(bs => bs.PassengerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}