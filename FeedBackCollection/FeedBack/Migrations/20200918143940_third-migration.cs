using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedBack.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Commentses");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Commentses",
                newName: "IX_Commentses_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commentses",
                table: "Commentses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentses_Posts_PostId",
                table: "Commentses",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentses_Posts_PostId",
                table: "Commentses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commentses",
                table: "Commentses");

            migrationBuilder.RenameTable(
                name: "Commentses",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Commentses_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
