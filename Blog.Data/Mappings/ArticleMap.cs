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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
              builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = " Asp.net Core Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.",
                ViewCount = 15,
                CategoryId = Guid.Parse("E2CAF291-90F4-4C56-977C-ECEDD4BE6F35"),
                ImageId =Guid.Parse("E4304CD3-09EE-4EAB-B23E-B25160CBACAD"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("80A80476-1989-4FF1-98B4-4ED30250624D"),

              },
              new Article
              {
                  Id = Guid.NewGuid(),
                  Title = "Ders Deneme  Makalesi 1",
                  Content = " Ders Deneme Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.",
                  ViewCount = 15,
                  CategoryId = Guid.Parse("176ABC05-4F2A-449C-841C-B292125CDCD6"),
                  ImageId = Guid.Parse("A46C0151-17C7-47F6-9E84-73699D6FC018"),
                  CreatedBy = "Admin Test",
                  CreatedDate = DateTime.Now,
                  IsDeleted = false,
                  UserId = Guid.Parse("3311DD66-BFFD-400D-98F3-604018FB08B0"),


              }

              
              
              
           
              );

        }
    }
}
