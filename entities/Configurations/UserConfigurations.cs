using entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entities.Configurations;

public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasOne(x => x.Role)
            .WithMany(x => x.Users)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.Otps)
            .WithOne(x => x.User)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}