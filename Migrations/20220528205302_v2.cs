using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Palka.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_Address1Id",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Address1Id",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_Address1Id",
                table: "AspNetUsers",
                column: "Address1Id",
                principalTable: "Address",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_Address1Id",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Address1Id",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_Address1Id",
                table: "AspNetUsers",
                column: "Address1Id",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
