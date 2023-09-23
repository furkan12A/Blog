using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"), "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4526), null, null, false, null, "Ders Deneme" },
                    { new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"), "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4519), null, null, false, null, "ASP.NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"), "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4882), null, null, "images/testimage", "png", false, null },
                    { new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"), "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4878), null, null, "images/testimage", "png", false, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("444236cc-c16f-4647-b104-7b616384a2a4"), new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"), " Asp.net Core Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.", "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(3873), null, null, new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"), false, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("f455d8a6-09d7-43a6-ab78-2a6417c4727a"), new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"), " Ders Deneme Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.", "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(3923), null, null, new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"), false, null, "Ders Deneme  Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("444236cc-c16f-4647-b104-7b616384a2a4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f455d8a6-09d7-43a6-ab78-2a6417c4727a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
