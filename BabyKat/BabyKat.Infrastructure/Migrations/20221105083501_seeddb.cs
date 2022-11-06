using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyKat.Infrastructure.Migrations
{
    public partial class seeddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Country", "CreatedDate", "DeletedOn", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastModifiedOn", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "09a599d7-7418-4ad8-a55b-afc59ac8a17e", "Bulgaria", new DateTime(2022, 11, 5, 10, 35, 1, 607, DateTimeKind.Local).AddTicks(6363), null, "agent@mail.com", false, "Ivan", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrov", false, null, "agent@mail.com", "ivancho", "AQAAAAEAACcQAAAAEL5T6UsflZ7LfZ/Zi1JZMbKdWwzPGu2313tJqdHJV33MsRO70LfoLb/g7WGmRbn5NQ==", null, false, "45e18d1a-5bc2-4edd-a287-f230ff63eb8c", false, "ivancho" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Strollers" },
                    { 2, "Car Seats" },
                    { 3, "Nursery" },
                    { 4, "Health" },
                    { 5, "Feeding" },
                    { 6, "Diaper" },
                    { 7, "Soothe" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, 6, "Pros: Rubber base, hold handle, suitable for multiple ages. Cons: Shallow seat, low splash guardSimple, sturdy, and easy to clean, this toddler toilet that has exactly what you need and no more.", "https://m.media-amazon.com/images/I/71XDXNt9n5L._SL1500_.jpg", "OXO Tot Potty Chair", 25.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, 6, "Pros: Deep bowl, convenient size, breeze to cleanCons: Limited age range, backlessSmall and functional potty that is perfect for budget minded parents", "https://m.media-amazon.com/images/I/61+uuyDhAcL._SL1500_.jpg", "BabyBjörn Smart Potty", 22.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
