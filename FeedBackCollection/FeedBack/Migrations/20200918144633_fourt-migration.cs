using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedBack.Migrations
{
    public partial class fourtmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Commentses",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Commentses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
