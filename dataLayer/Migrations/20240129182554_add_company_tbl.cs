using Microsoft.EntityFrameworkCore.Migrations;

namespace dataLayer.Migrations
{
    public partial class add_company_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    is_deleted = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: false),
                    fax = table.Column<string>(nullable: true),
                    accountant = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    website = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
