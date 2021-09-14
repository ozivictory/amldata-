using Microsoft.EntityFrameworkCore.Migrations;

namespace amldata.Migrations
{
    public partial class opp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "CTR",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "CTR");
        }
    }
}
