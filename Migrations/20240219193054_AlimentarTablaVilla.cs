using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagiVilla.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActuslizacion", "FechaCreaccion" },
                values: new object[] { new DateTime(2024, 2, 19, 15, 30, 54, 551, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 2, 19, 15, 30, 54, 551, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActuslizacion", "FechaCreaccion" },
                values: new object[] { new DateTime(2024, 2, 19, 15, 30, 54, 551, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 2, 19, 15, 30, 54, 551, DateTimeKind.Local).AddTicks(7269) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActuslizacion", "FechaCreaccion" },
                values: new object[] { new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActuslizacion", "FechaCreaccion" },
                values: new object[] { new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6802) });
        }
    }
}
