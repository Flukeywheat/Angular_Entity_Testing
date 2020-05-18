using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspNetCoreDemo.Migrations
{
    public partial class Navbar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    NavBarCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.NavBarCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "navBarDropDownItem",
                columns: table => new
                {
                    NavBarDropDownItemiD = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar (100)", nullable: false),
                    relativePath = table.Column<string>(type: "varchar (100)", nullable: false),
                    NavBarCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_navBarDropDownItem", x => x.NavBarDropDownItemiD);
                    table.ForeignKey(
                        name: "FK_navBarDropDownItem_Categories_NavBarCategoryId",
                        column: x => x.NavBarCategoryId,
                        principalTable: "Categories",
                        principalColumn: "NavBarCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_navBarDropDownItem_NavBarCategoryId",
                table: "navBarDropDownItem",
                column: "NavBarCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "navBarDropDownItem");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
