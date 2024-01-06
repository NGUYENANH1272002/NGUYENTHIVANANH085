using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NGUYENTHIVANANH_085.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Lophoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lophocs",
                columns: table => new
                {
                    Malop = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tenlop = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lophocs", x => x.Malop);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lophocs");
        }
    }
}
