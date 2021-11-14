using Microsoft.EntityFrameworkCore.Migrations;

namespace examen_final_5390_18_10587.Migrations
{
    public partial class examen_final_5390_18_10587 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Ingreso_producto",
                columns: table => new
                {
                    IngresoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreBodegaIngreso = table.Column<string>(type: "varchar(50)", nullable: false),
                    NombreProductoIngreso = table.Column<string>(type: "varchar(50)", nullable: false),
                    CantidadProductoIngreso = table.Column<int>(type: "int", nullable: false),
                    PrecioProductoIngreso = table.Column<int>(type: "int", nullable: false),
                    ProveedorProductoIngreso = table.Column<string>(type: "varchar(50)", nullable: false),
                    EstadoProveedor = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Ingreso_producto", x => x.IngresoProducto);
                });

            migrationBuilder.CreateTable(
                name: "tbl_producto",
                columns: table => new
                {
                    CodigoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "varchar(50)", nullable: false),
                    ProveedorProducto = table.Column<string>(type: "varchar(50)", nullable: false),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    PrecioProducto = table.Column<int>(type: "int", nullable: false),
                    EstadoProducto = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_producto", x => x.CodigoProducto);
                });

            migrationBuilder.CreateTable(
                name: "tbl_proveedor",
                columns: table => new
                {
                    CodigoProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(type: "varchar(50)", nullable: false),
                    DireccionProducto = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefonoproveedor = table.Column<int>(type: "int", nullable: false),
                    ProveedorProducto = table.Column<string>(type: "varchar(50)", nullable: false),
                    EstadoProveedor = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_proveedor", x => x.CodigoProveedor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Ingreso_producto");

            migrationBuilder.DropTable(
                name: "tbl_producto");

            migrationBuilder.DropTable(
                name: "tbl_proveedor");
        }
    }
}
