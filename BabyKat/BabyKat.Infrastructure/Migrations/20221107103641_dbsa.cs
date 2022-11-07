using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyKat.Infrastructure.Migrations
{
    public partial class dbsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16a4fce5-7a31-449b-8b4e-a141033c9b18", new DateTime(2022, 11, 7, 12, 36, 41, 102, DateTimeKind.Local).AddTicks(8571), "AQAAAAEAACcQAAAAEIogGNDiK9QgZ+Le7SNLkp4h9Z4uYR/Lv9qdlLYrK684L+ez7tmUI9CiBI73uwby0A==", "d3a23764-4fbe-44c8-b5cc-6066769a719f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25dca380-b77c-4621-b367-5cee4aef1a8e", new DateTime(2022, 11, 6, 21, 14, 28, 612, DateTimeKind.Local).AddTicks(7041), "AQAAAAEAACcQAAAAEJcEuUrZQ6PaS23ScYyUDgLm878HX57jGXogjgV+60Dipe45a3QNPcgG/RJ18y8AMA==", "135dae00-b8f3-46c1-85bb-2d6d17939398" });
        }
    }
}
