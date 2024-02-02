using Microsoft.EntityFrameworkCore.Migrations;

namespace dataLayer.Migrations
{
    public partial class add_default_val_company_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "website",
                table: "companies",
                nullable: true,
                defaultValue: "غير متوفر موقع الكترونى",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "fax",
                table: "companies",
                nullable: true,
                defaultValue: "غير متوفر فاكس",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "companies",
                nullable: true,
                defaultValue: "غير متوفر بريد الكترونى",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "companies",
                nullable: true,
                defaultValue: "غير متوفر عنوان",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "accountant",
                table: "companies",
                nullable: true,
                defaultValue: "غير متوفر مسئول",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "website",
                table: "companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "غير متوفر موقع الكترونى");

            migrationBuilder.AlterColumn<string>(
                name: "fax",
                table: "companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "غير متوفر فاكس");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "غير متوفر بريد الكترونى");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "غير متوفر عنوان");

            migrationBuilder.AlterColumn<string>(
                name: "accountant",
                table: "companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "غير متوفر مسئول");
        }
    }
}
