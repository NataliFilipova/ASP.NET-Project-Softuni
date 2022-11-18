using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyKat.Infrastructure.Migrations
{
    public partial class addRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Articles",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "247cd6c4-24b7-48f6-91b5-1fcf86a235f5", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "abaa6ad5-17fd-4fe5-819d-3d0fad722055", "User", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52f466b4-e24e-4179-bac8-e90cb86c3ace", new DateTime(2022, 11, 18, 21, 3, 49, 185, DateTimeKind.Local).AddTicks(1293), "AQAAAAEAACcQAAAAEC9GE181zBPznwOLcVk0wLQXhckGMQdaorK7gK363pQL2mjXdEDRsM8I0Bbiwt/DNQ==", "7d83c379-ce1c-43bd-a2c8-ea093e9e9ae3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28acb5a0-a1f1-4447-ac1b-1ea05c8a568a", new DateTime(2022, 11, 12, 18, 6, 52, 810, DateTimeKind.Local).AddTicks(478), "AQAAAAEAACcQAAAAEEj4bTtZy33XoUeLq0nfNTsm/LS6OTd0tECDsK/5+VRaLhMCfBagl98oeSgJhizpOw==", "6d259600-95ff-4dc7-b042-647e2e73eee9" });
        }
    }
}
