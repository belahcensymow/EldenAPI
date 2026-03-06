using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SitesOfGrace",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IconId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubRegionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Text1 = table.Column<string>(type: "TEXT", nullable: false),
                    Text2 = table.Column<string>(type: "TEXT", nullable: false),
                    Text3 = table.Column<string>(type: "TEXT", nullable: false),
                    Text4 = table.Column<string>(type: "TEXT", nullable: false),
                    Text5 = table.Column<string>(type: "TEXT", nullable: false),
                    Text6 = table.Column<string>(type: "TEXT", nullable: false),
                    Text7 = table.Column<string>(type: "TEXT", nullable: false),
                    Text8 = table.Column<string>(type: "TEXT", nullable: false),
                    PosX = table.Column<float>(type: "REAL", nullable: false),
                    PosY = table.Column<float>(type: "REAL", nullable: false),
                    PosZ = table.Column<float>(type: "REAL", nullable: false),
                    AreaNo = table.Column<int>(type: "INTEGER", nullable: false),
                    GridXNo = table.Column<int>(type: "INTEGER", nullable: false),
                    GridZNo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitesOfGrace", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SitesOfGrace");
        }
    }
}
