using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresProje.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deneme",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deneme", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "deneme_pres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URETIM_TARIH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VARDIYA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MESAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_EMRI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARCA_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPERASYON_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURE_DK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPERATOR_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HATA_KODU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HATA_TANIMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VURUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_IS_EMRI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deneme_pres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HAT_PRES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HAT_PRES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hata_Listesi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HataKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HataTanimi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hata_Listesi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PARCA_LISTESI",
                columns: table => new
                {
                    Malzeme = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARCA_LISTESI", x => x.Malzeme);
                });

            migrationBuilder.CreateTable(
                name: "PRES_PROD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URETIM_TARIH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VARDIYA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MESAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_EMRI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARCA_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPERASYON_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURE_DK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPERATOR_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HATA_KODU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HATA_TANIMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VURUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_IS_EMRI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRES_PROD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeepLoggedIn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deneme");

            migrationBuilder.DropTable(
                name: "deneme_pres");

            migrationBuilder.DropTable(
                name: "HAT_PRES");

            migrationBuilder.DropTable(
                name: "Hata_Listesi");

            migrationBuilder.DropTable(
                name: "PARCA_LISTESI");

            migrationBuilder.DropTable(
                name: "PRES_PROD");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
