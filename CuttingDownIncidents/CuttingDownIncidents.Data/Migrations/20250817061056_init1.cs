using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuttingDownIncidents.Data.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_A_Problem_Type_ProblemTypeProblem_Type_Key",
                table: "Cutting_Down_A");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_B_Incident_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Detail_Cutting_Down_Header_Cutting_Down_HeaderCutting_Down_Key",
                table: "Cutting_Down_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Header_Cutting_Down_Ignored_CuttingDownIgnoredCutting_Down_Incident_ID",
                table: "Cutting_Down_Header");

            migrationBuilder.AlterColumn<int>(
                name: "CuttingDownIgnoredCutting_Down_Incident_ID",
                table: "Cutting_Down_Header",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cutting_Down_HeaderCutting_Down_Key",
                table: "Cutting_Down_Detail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Problem_Type_Key1",
                table: "Cutting_Down_B_Incident",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProblemTypeProblem_Type_Key",
                table: "Cutting_Down_A",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_A_Problem_Type_ProblemTypeProblem_Type_Key",
                table: "Cutting_Down_A",
                column: "ProblemTypeProblem_Type_Key",
                principalTable: "Problem_Type",
                principalColumn: "Problem_Type_Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_B_Incident_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident",
                column: "Problem_Type_Key1",
                principalTable: "Problem_Type",
                principalColumn: "Problem_Type_Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Detail_Cutting_Down_Header_Cutting_Down_HeaderCutting_Down_Key",
                table: "Cutting_Down_Detail",
                column: "Cutting_Down_HeaderCutting_Down_Key",
                principalTable: "Cutting_Down_Header",
                principalColumn: "Cutting_Down_Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Header_Cutting_Down_Ignored_CuttingDownIgnoredCutting_Down_Incident_ID",
                table: "Cutting_Down_Header",
                column: "CuttingDownIgnoredCutting_Down_Incident_ID",
                principalTable: "Cutting_Down_Ignored",
                principalColumn: "Cutting_Down_Incident_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_A_Problem_Type_ProblemTypeProblem_Type_Key",
                table: "Cutting_Down_A");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_B_Incident_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Detail_Cutting_Down_Header_Cutting_Down_HeaderCutting_Down_Key",
                table: "Cutting_Down_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Cutting_Down_Header_Cutting_Down_Ignored_CuttingDownIgnoredCutting_Down_Incident_ID",
                table: "Cutting_Down_Header");

            migrationBuilder.AlterColumn<int>(
                name: "CuttingDownIgnoredCutting_Down_Incident_ID",
                table: "Cutting_Down_Header",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cutting_Down_HeaderCutting_Down_Key",
                table: "Cutting_Down_Detail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Problem_Type_Key1",
                table: "Cutting_Down_B_Incident",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProblemTypeProblem_Type_Key",
                table: "Cutting_Down_A",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_A_Problem_Type_ProblemTypeProblem_Type_Key",
                table: "Cutting_Down_A",
                column: "ProblemTypeProblem_Type_Key",
                principalTable: "Problem_Type",
                principalColumn: "Problem_Type_Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_B_Incident_Problem_Type_Problem_Type_Key1",
                table: "Cutting_Down_B_Incident",
                column: "Problem_Type_Key1",
                principalTable: "Problem_Type",
                principalColumn: "Problem_Type_Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Detail_Cutting_Down_Header_Cutting_Down_HeaderCutting_Down_Key",
                table: "Cutting_Down_Detail",
                column: "Cutting_Down_HeaderCutting_Down_Key",
                principalTable: "Cutting_Down_Header",
                principalColumn: "Cutting_Down_Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cutting_Down_Header_Cutting_Down_Ignored_CuttingDownIgnoredCutting_Down_Incident_ID",
                table: "Cutting_Down_Header",
                column: "CuttingDownIgnoredCutting_Down_Incident_ID",
                principalTable: "Cutting_Down_Ignored",
                principalColumn: "Cutting_Down_Incident_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
