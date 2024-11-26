using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBalzor.Migrations
{
    /// <inheritdoc />
    public partial class DM_Kho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DM_Kho",
                columns: table => new
                {
                    Ten_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_Kho", x => x.Ten_Kho);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DM_Kho");
        }
    }
}
