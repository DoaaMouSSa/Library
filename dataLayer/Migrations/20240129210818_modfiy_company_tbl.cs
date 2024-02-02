using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dataLayer.Migrations
{
    public partial class modfiy_company_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "added_date",
                table: "companies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_date",
                table: "companies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "companies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "added_date",
                table: "companies");

            migrationBuilder.DropColumn(
                name: "deleted_date",
                table: "companies");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "companies");
        }
    }
}
