using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuttingDownIncidents.Data.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Detail_Network_Element_networkElementNetwork_Element_Key",
                table: "Cutting_Down_Detail");

            migrationBuilder.AlterColumn<int>(
                name: "networkElementNetwork_Element_Key",
                table: "Cutting_Down_Detail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    Channel_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Channel_Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.Channel_Key);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Detail_Network_Element_networkElementNetwork_Element_Key",
                table: "Cutting_Down_Detail",
                column: "networkElementNetwork_Element_Key",
                principalTable: "Network_Element",
                principalColumn: "Network_Element_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Detail_Network_Element_networkElementNetwork_Element_Key",
                table: "Cutting_Down_Detail");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.AlterColumn<int>(
                name: "networkElementNetwork_Element_Key",
                table: "Cutting_Down_Detail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Detail_Network_Element_networkElementNetwork_Element_Key",
                table: "Cutting_Down_Detail",
                column: "networkElementNetwork_Element_Key",
                principalTable: "Network_Element",
                principalColumn: "Network_Element_Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
