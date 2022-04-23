using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciertos1.Migrations
{
    public partial class addEntranceEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrance_EntranceId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrance",
                table: "Entrance");

            migrationBuilder.RenameTable(
                name: "Entrance",
                newName: "Entrances");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Entrances",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrances",
                table: "Entrances",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Id",
                table: "Entrances",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets",
                column: "EntranceId",
                principalTable: "Entrances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrances",
                table: "Entrances");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_Id",
                table: "Entrances");

            migrationBuilder.RenameTable(
                name: "Entrances",
                newName: "Entrance");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Entrance",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrance",
                table: "Entrance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrance_EntranceId",
                table: "Tickets",
                column: "EntranceId",
                principalTable: "Entrance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
