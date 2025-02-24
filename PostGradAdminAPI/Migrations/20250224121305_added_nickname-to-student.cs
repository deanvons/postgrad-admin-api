using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostGradAdminAPI.Migrations
{
    /// <inheritdoc />
    public partial class added_nicknametostudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Students");
        }
    }
}
