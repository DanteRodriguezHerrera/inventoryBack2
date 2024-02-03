using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inventoryBack2.Migrations
{
    /// <inheritdoc />
    public partial class InventoryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pertenece = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Fondo = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Unidad_Presupuestal = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Cuenta = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Subcuenta = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Folio = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Cantidad = table.Column<byte>(type: "tinyint", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Serie_De_Fabrica = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Responsable = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Num_Empleado = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryDetails");
        }
    }
}
