using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conciertos1.Migrations
{
    public partial class AddIndextIcket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateIndex(
            //    name: "IX_Tickets_Name",
            //    table: "Tickets",
            //    column: "Name",
            //    unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //   name: "IX_Tickets_Name",
            //   table: "Tickets");
        }
    }
}
