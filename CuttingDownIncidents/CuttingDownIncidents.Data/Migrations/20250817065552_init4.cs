using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuttingDownIncidents.Data.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cabel_Name",
                table: "Cutting_Down_Ignored",
                newName: "Cable_Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cable_Name",
                table: "Cutting_Down_Ignored",
                newName: "Cabel_Name");
        }
    }
}
