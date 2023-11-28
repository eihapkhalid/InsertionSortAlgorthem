using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsertionSortAlgorthem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbEmbloyees",
                columns: table => new
                {
                    EmbloyeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmbloyeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmbloyeeAge = table.Column<int>(type: "int", nullable: false),
                    EmbloyeeSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmbloyeeIsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmbloyees", x => x.EmbloyeeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbEmbloyees");
        }
    }
}
