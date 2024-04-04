using entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entities.DataContexts;

public class OtpConfigurations: IEntityTypeConfiguration<Otp>
{
    public void Configure(EntityTypeBuilder<Otp> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.Otps)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}