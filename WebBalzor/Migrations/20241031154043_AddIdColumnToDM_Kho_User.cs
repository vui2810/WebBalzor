using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBalzor.Migrations
{
    /// <inheritdoc />
    public partial class AddIdColumnToDM_Kho_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DM_Kho_User",
                table: "DM_Kho_User");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DM_Kho_User",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DM_Kho_User",
                table: "DM_Kho_User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DM_Kho_User_Ma_Dang_Nhap_Kho_ID",
                table: "DM_Kho_User",
                columns: new[] { "Ma_Dang_Nhap", "Kho_ID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DM_Kho_User",
                table: "DM_Kho_User");

            migrationBuilder.DropIndex(
                name: "IX_DM_Kho_User_Ma_Dang_Nhap_Kho_ID",
                table: "DM_Kho_User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DM_Kho_User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DM_Kho_User",
                table: "DM_Kho_User",
                column: "Ma_Dang_Nhap");
        }
    }
}
