using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Project.EF.Migrations
{
    public partial class up_confirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Orders",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Orders");
        }
    }
}
