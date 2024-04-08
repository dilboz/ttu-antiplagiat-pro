using entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entities.Configurations;

public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //set id as primary key
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.FirstName).IsRequired();
        builder.Property(x => x.LastName).IsRequired();
        builder.Property(x => x.PhoneNumber).IsRequired();
        builder.Property(x => x.RoleId).IsRequired();
        
        builder.HasOne(x => x.Role)
            .WithMany(x => x.Users)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
    }
}