using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLabb4.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebSite_Interests_interestId",
                table: "WebSite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebSite",
                table: "WebSite");

            migrationBuilder.RenameTable(
                name: "WebSite",
                newName: "WebSites");

            migrationBuilder.RenameIndex(
                name: "IX_WebSite_interestId",
                table: "WebSites",
                newName: "IX_WebSites_interestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebSites",
                table: "WebSites",
                column: "WebSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_WebSites_Interests_interestId",
                table: "WebSites",
                column: "interestId",
                principalTable: "Interests",
                principalColumn: "interestId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebSites_Interests_interestId",
                table: "WebSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebSites",
                table: "WebSites");

            migrationBuilder.RenameTable(
                name: "WebSites",
                newName: "WebSite");

            migrationBuilder.RenameIndex(
                name: "IX_WebSites_interestId",
                table: "WebSite",
                newName: "IX_WebSite_interestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebSite",
                table: "WebSite",
                column: "WebSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_WebSite_Interests_interestId",
                table: "WebSite",
                column: "interestId",
                principalTable: "Interests",
                principalColumn: "interestId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
