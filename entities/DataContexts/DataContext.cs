using entities.Configurations;
using entities.Models;
using Microsoft.EntityFrameworkCore;

namespace entities.DataContexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<Otp> Otps { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RoleConfigurations());
        modelBuilder.ApplyConfiguration(new UserConfigurations());
        modelBuilder.ApplyConfiguration(new OtpConfigurations());
        
        base.OnModelCreating(modelBuilder);
    }
}