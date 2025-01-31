using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Echo_Merch.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table1_",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1_", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Table1_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table1_Table1__Table1_Id",
                        column: x => x.Table1_Id,
                        principalTable: "Table1_",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Table1_Table1_Id",
                table: "Table1",
                column: "Table1_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table1");

            migrationBuilder.DropTable(
                name: "Table1_");
        }
    }
}
