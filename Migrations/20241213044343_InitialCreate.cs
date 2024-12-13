using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerBank.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    CollegeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollegeName = table.Column<string>(type: "TEXT", nullable: false),
                    CollegeState = table.Column<string>(type: "TEXT", nullable: false),
                    CollegeCity = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.CollegeID);
                });

            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    AthleteID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Sport = table.Column<string>(type: "TEXT", nullable: false),
                    CollegeID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.AthleteID);
                    table.ForeignKey(
                        name: "FK_Athletes_Colleges_CollegeID",
                        column: x => x.CollegeID,
                        principalTable: "Colleges",
                        principalColumn: "CollegeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_CollegeID",
                table: "Athletes",
                column: "CollegeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropTable(
                name: "Colleges");
        }
    }
}
