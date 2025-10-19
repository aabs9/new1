using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CarType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CarNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    Remaining = table.Column<int>(type: "INTEGER", nullable: false),
                    Areas = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    HasAC = table.Column<bool>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    GenderType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentSearches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Keyword = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Area = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CarNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    DriverName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DriverCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSearches", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "StudentSearches");
        }
    }
}
