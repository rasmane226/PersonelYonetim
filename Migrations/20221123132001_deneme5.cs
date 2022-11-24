using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelYonetim.Migrations
{
    public partial class deneme5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aktifs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aktifs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personelid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unvanid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aktifs", x => x.id);
                });
        }
    }
}
