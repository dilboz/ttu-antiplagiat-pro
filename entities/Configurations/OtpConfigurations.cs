using entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entities.Configurations;

public class OtpConfigurations: IEntityTypeConfiguration<Otp>
{
    public void Configure(EntityTypeBuilder<Otp> builder)
    {
        //set id as primary key
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Email).IsRequired();
        builder.Property(x => x.Key).IsRequired();
        builder.Property(x => x.Message).IsRequired();
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow);
        builder.Property(x => x.ExpiredAt).IsRequired();
    }
}