using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyKat.Infrastructure.Migrations
{
    public partial class addigndescript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e782bc-4cc9-4b4e-89f2-ee5fcc840f2c", new DateTime(2022, 11, 6, 19, 56, 10, 980, DateTimeKind.Local).AddTicks(8311), "AQAAAAEAACcQAAAAEMOT5ZVsJBBcSmxehLKLdg2R8HS+Q1+8IG1H7iA9tQ/g5EnoMURdfiGa6k2u/2x9aw==", "b3a0bf7e-9ec7-4cd8-86ae-b85b3e66246e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a599d7-7418-4ad8-a55b-afc59ac8a17e", new DateTime(2022, 11, 5, 10, 35, 1, 607, DateTimeKind.Local).AddTicks(6363), "AQAAAAEAACcQAAAAEL5T6UsflZ7LfZ/Zi1JZMbKdWwzPGu2313tJqdHJV33MsRO70LfoLb/g7WGmRbn5NQ==", "45e18d1a-5bc2-4edd-a287-f230ff63eb8c" });
        }
    }
}
