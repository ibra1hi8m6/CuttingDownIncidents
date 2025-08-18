using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuttingDownIncidents.Data.Migrations
{
    /// <inheritdoc />
    public partial class init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Channel_Key1",
                table: "Cutting_Down_Header",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Header_Channel_Key1",
                table: "Cutting_Down_Header",
                column: "Channel_Key1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Header_Channel_Channel_Key1",
                table: "Cutting_Down_Header",
                column: "Channel_Key1",
                principalTable: "Channel",
                principalColumn: "Channel_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Header_Channel_Channel_Key1",
                table: "Cutting_Down_Header");

            migrationBuilder.DropIndex(
                name: "IX_Cutting_Down_Header_Channel_Key1",
                table: "Cutting_Down_Header");

            migrationBuilder.DropColumn(
                name: "Channel_Key1",
                table: "Cutting_Down_Header");
        }
    }
}
