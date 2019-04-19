using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Razor_2_1.Migrations
{
    public partial class ChangeBookNameToNameOfBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "NameOfBook");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameOfBook",
                table: "Books",
                newName: "Name");
        }
    }
}
