using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagiVilla.Migrations
{
    /// <inheritdoc />
    public partial class AgregarBaseDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarifa = table.Column<double>(type: "float", nullable: false),
                    Ocupantes = table.Column<int>(type: "int", nullable: false),
                    MetrosCuadrados = table.Column<int>(type: "int", nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaActuslizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActuslizacion", "FechaCreaccion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa...", new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6789), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa...", new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6802), "", 40, "Premium vista a la pscina", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "villas");
        }
    }
}
