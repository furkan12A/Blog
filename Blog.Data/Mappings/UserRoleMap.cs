using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    internal class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });
           
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("80A80476-1989-4FF1-98B4-4ED30250624D"),
                RoleId = Guid.Parse("D9795D58-A7B5-4546-A9F9-252C9203918C"),

            }, 
            new AppUserRole
            {
                UserId = Guid.Parse("80A80476-1989-4FF1-98B4-4ED30250624D"),
                RoleId = Guid.Parse("A08B4329-AB58-4053-AB14-0EF2AB0DE26D"),

            });
            
        }
    }
}
