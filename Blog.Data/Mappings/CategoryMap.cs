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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("E2CAF291-90F4-4C56-977C-ECEDD4BE6F35"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            },

            new Category
            {
                
                  
                      Id = Guid.Parse("176ABC05-4F2A-449C-841C-B292125CDCD6"),
                      Name = "Ders Deneme",
                      CreatedBy = "Admin Test",
                      CreatedDate = DateTime.Now,
                      IsDeleted = false,

                  


            });
         

        }
    }
}
