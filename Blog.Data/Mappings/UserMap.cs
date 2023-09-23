using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(u => u.Id);


            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");


            builder.ToTable("AspNetUsers");


            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);




            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();


            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();


            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();


            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var superadmin = new AppUser
            {
                Id = Guid.Parse("80A80476-1989-4FF1-98B4-4ED30250624D"),
                UserName = "superadmin@gmail.com",
                NormalizedUserName = "SUPERADMİN@GMAİL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMİN@GMAİL.COM",
                PhoneNumber = "+905375756282",
                FirstName = "Furkan",
                LastName = "Ayaoku",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("E4304CD3-09EE-4EAB-B23E-B25160CBACAD"),
            };

            superadmin.PasswordHash = CreatedPasswordHash(superadmin, "1903");

            var admin = new AppUser
            {
                Id = Guid.Parse("3311DD66-BFFD-400D-98F3-604018FB08B0"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMİN@GMAİL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMİN@GMAİL.COM",
                PhoneNumber = "+905375756281",
                FirstName = "Admin",
                LastName = "User",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId = Guid.Parse("E4304CD3-09EE-4EAB-B23E-B25160CBACAD"),

            };
            superadmin.PasswordHash = CreatedPasswordHash(admin, "1903");

            builder.HasData(superadmin, admin);

        }

        private string CreatedPasswordHash(AppUser user ,string password)
        {
            var passwordHasher =new PasswordHasher<AppUser>();  
            return passwordHasher.HashPassword(user , password);


        }
    }
}
