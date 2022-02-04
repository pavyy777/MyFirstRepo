using Microsoft.EntityFrameworkCore.Migrations;

namespace HMS.DAL.Migrations
{
    public partial class uploded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "registrationOPD");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "registrationIPD");

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "registrationOPD",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "registrationIPD",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "registrationOPD");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "registrationIPD");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "registrationOPD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "registrationIPD",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
