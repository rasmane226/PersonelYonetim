using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelYonetim.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<int>(type: "int", nullable: false),
                    tel = table.Column<int>(type: "int", nullable: false),
                    unvanid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Unvans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unvanad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personelid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvans", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aktifs");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "Unvans");
        }
    }
}
