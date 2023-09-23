using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("444236cc-c16f-4647-b104-7b616384a2a4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f455d8a6-09d7-43a6-ab78-2a6417c4727a"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1b2a7db6-c7fb-40c5-8bfc-ed69e0c1309c"), new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"), " Asp.net Core Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.", "Admin Test", new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(295), null, null, new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"), false, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("7e323924-e7f6-41e8-91b3-500c2b7683cb"), new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"), " Ders Deneme Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.", "Admin Test", new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(318), null, null, new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"), false, null, "Ders Deneme  Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1561));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1b2a7db6-c7fb-40c5-8bfc-ed69e0c1309c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7e323924-e7f6-41e8-91b3-500c2b7683cb"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("444236cc-c16f-4647-b104-7b616384a2a4"), new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"), " Asp.net Core Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.", "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(3873), null, null, new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"), false, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("f455d8a6-09d7-43a6-ab78-2a6417c4727a"), new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"), " Ders Deneme Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.", "Admin Test", new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(3923), null, null, new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"), false, null, "Ders Deneme  Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 4, 52, 0, 526, DateTimeKind.Local).AddTicks(4878));
        }
    }
}
