using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuttingDownIncidents.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_B_Incident_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cutting_Down_B_Incident",
                table: "Cutting_Down_B_Incident");

            migrationBuilder.RenameTable(
                name: "Cutting_Down_B_Incident",
                newName: "Cutting_Down_B");

            migrationBuilder.RenameIndex(
                name: "IX_Cutting_Down_B_Incident_Problem_Type_Key1",
                table: "Cutting_Down_B",
                newName: "IX_Cutting_Down_B_Problem_Type_Key1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cutting_Down_B",
                table: "Cutting_Down_B",
                column: "Cutting_Down_B_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_B_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B",
                column: "Problem_Type_Key1",
                principalTable: "Problem_Type",
                principalColumn: "Problem_Type_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_B_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cutting_Down_B",
                table: "Cutting_Down_B");

            migrationBuilder.RenameTable(
                name: "Cutting_Down_B",
                newName: "Cutting_Down_B_Incident");

            migrationBuilder.RenameIndex(
                name: "IX_Cutting_Down_B_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident",
                newName: "IX_Cutting_Down_B_Incident_Problem_Type_Key1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cutting_Down_B_Incident",
                table: "Cutting_Down_B_Incident",
                column: "Cutting_Down_B_Incident_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_B_Incident_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident",
                column: "Problem_Type_Key1",
                principalTable: "Problem_Type",
                principalColumn: "Problem_Type_Key");
        }
    }
}
