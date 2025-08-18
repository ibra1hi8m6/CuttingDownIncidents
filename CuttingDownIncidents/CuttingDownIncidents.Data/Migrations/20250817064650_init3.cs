using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuttingDownIncidents.Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Network_Element_Network_Element_Type_NetworkElementTypeNetwork_Element_Type_Key",
                table: "Network_Element");

            migrationBuilder.DropForeignKey(
                name: "FK_Network_Element_Type_Network_Element_Hierarchy_Path_NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                table: "Network_Element_Type");

            migrationBuilder.AlterColumn<int>(
                name: "NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                table: "Network_Element_Type",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NetworkElementTypeNetwork_Element_Type_Key",
                table: "Network_Element",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Network_Element_Network_Element_Type_NetworkElementTypeNetwork_Element_Type_Key",
                table: "Network_Element",
                column: "NetworkElementTypeNetwork_Element_Type_Key",
                principalTable: "Network_Element_Type",
                principalColumn: "Network_Element_Type_Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Network_Element_Type_Network_Element_Hierarchy_Path_NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                table: "Network_Element_Type",
                column: "NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                principalTable: "Network_Element_Hierarchy_Path",
                principalColumn: "Network_Element_Hierarchy_Path_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Network_Element_Network_Element_Type_NetworkElementTypeNetwork_Element_Type_Key",
                table: "Network_Element");

            migrationBuilder.DropForeignKey(
                name: "FK_Network_Element_Type_Network_Element_Hierarchy_Path_NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                table: "Network_Element_Type");

            migrationBuilder.AlterColumn<int>(
                name: "NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                table: "Network_Element_Type",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NetworkElementTypeNetwork_Element_Type_Key",
                table: "Network_Element",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Network_Element_Network_Element_Type_NetworkElementTypeNetwork_Element_Type_Key",
                table: "Network_Element",
                column: "NetworkElementTypeNetwork_Element_Type_Key",
                principalTable: "Network_Element_Type",
                principalColumn: "Network_Element_Type_Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Network_Element_Type_Network_Element_Hierarchy_Path_NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                table: "Network_Element_Type",
                column: "NetworkElementHierarchyPathNetwork_Element_Hierarchy_Path_Key",
                principalTable: "Network_Element_Hierarchy_Path",
                principalColumn: "Network_Element_Hierarchy_Path_Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
