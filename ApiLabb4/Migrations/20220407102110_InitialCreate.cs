using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLabb4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    personId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.personId);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    interestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    personId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.interestId);
                    table.ForeignKey(
                        name: "FK_Interests_Persons_personId",
                        column: x => x.personId,
                        principalTable: "Persons",
                        principalColumn: "personId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebSite",
                columns: table => new
                {
                    WebSiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteURL = table.Column<string>(nullable: true),
                    interestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebSite", x => x.WebSiteId);
                    table.ForeignKey(
                        name: "FK_WebSite_Interests_interestId",
                        column: x => x.interestId,
                        principalTable: "Interests",
                        principalColumn: "interestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_personId",
                table: "Interests",
                column: "personId");

            migrationBuilder.CreateIndex(
                name: "IX_WebSite_interestId",
                table: "WebSite",
                column: "interestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebSite");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
