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
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(r => r.Id);

            
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            
            builder.ToTable("AspNetRoles");

          
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

          
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

         

           
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

           
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                      Id = Guid.Parse("D9795D58-A7B5-4546-A9F9-252C9203918C"),
                      Name = "Superadmin",
                      NormalizedName = "SUPERADMİN",
                      ConcurrencyStamp = Guid.NewGuid().ToString(), 
            },

            new AppRole
            {
                Id = Guid.Parse("A08B4329-AB58-4053-AB14-0EF2AB0DE26D"),
                Name = "Admin",
                NormalizedName = "ADMİN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                


            },
            new AppRole
            {
                Id = Guid.Parse("010DD980-6272-4879-B1DF-4452F6951B25"),
                Name = "User",
                NormalizedName= "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),   

            });
            

                
        }
    }
}
