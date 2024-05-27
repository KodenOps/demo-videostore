using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoStore.Data.Migrations
{
    public partial class synopsisadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "synopsis",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "synopsis",
                table: "movies");
        }
    }
}
