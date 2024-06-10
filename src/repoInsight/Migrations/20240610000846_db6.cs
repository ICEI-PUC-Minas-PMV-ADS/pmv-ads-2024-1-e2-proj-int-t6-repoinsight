using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace repoInsight.Migrations
{
    /// <inheritdoc />
    public partial class db6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QtdBranches",
                table: "Repo");

            migrationBuilder.DropColumn(
                name: "QtdCommits",
                table: "Repo");

            migrationBuilder.DropColumn(
                name: "QtdContribuintes",
                table: "Repo");

            migrationBuilder.DropColumn(
                name: "QtdPrs",
                table: "Repo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtdBranches",
                table: "Repo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtdCommits",
                table: "Repo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtdContribuintes",
                table: "Repo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtdPrs",
                table: "Repo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
