using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyKat.Infrastructure.Migrations
{
    public partial class loshomie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25dca380-b77c-4621-b367-5cee4aef1a8e", new DateTime(2022, 11, 6, 21, 14, 28, 612, DateTimeKind.Local).AddTicks(7041), "AQAAAAEAACcQAAAAEJcEuUrZQ6PaS23ScYyUDgLm878HX57jGXogjgV+60Dipe45a3QNPcgG/RJ18y8AMA==", "135dae00-b8f3-46c1-85bb-2d6d17939398" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e782bc-4cc9-4b4e-89f2-ee5fcc840f2c", new DateTime(2022, 11, 6, 19, 56, 10, 980, DateTimeKind.Local).AddTicks(8311), "AQAAAAEAACcQAAAAEMOT5ZVsJBBcSmxehLKLdg2R8HS+Q1+8IG1H7iA9tQ/g5EnoMURdfiGa6k2u/2x9aw==", "b3a0bf7e-9ec7-4cd8-86ae-b85b3e66246e" });
        }
    }
}
