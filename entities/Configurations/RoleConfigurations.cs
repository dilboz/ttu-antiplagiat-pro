using entities.Enums;
using entities.Helpers;
using entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entities.Configurations;

public class RoleConfigurations:IEntityTypeConfiguration <Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        foreach (var roles in (Roles[]) Enum.GetValues(typeof(Roles)))
        {
            builder.HasData(new Role
            {
                Id = roles,
                Name = EnumHelper.GetEnumDescription(roles)
            });
        }
    }
}