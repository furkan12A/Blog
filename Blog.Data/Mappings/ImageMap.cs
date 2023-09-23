using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = Blog.Entity.Entities.Image;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
               
                  
                      Id  = Guid.Parse("E4304CD3-09EE-4EAB-B23E-B25160CBACAD"),
                      FileName = "images/testimage",
                      FileType = "png",
                      CreatedBy = "Admin Test",
                      CreatedDate = DateTime.Now,
                      IsDeleted = false,

                  


            },
            new Image 
            {
              
                  
                      Id = Guid.Parse("A46C0151-17C7-47F6-9E84-73699D6FC018"),
                      FileName = "images/testimage",
                      FileType = "png",
                      CreatedBy = "Admin Test",
                      CreatedDate = DateTime.Now,
                      IsDeleted = false,


            });
            
           
        }
    }
}
