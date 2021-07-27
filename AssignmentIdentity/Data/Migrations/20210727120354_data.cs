using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentIdentity.Data.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godiste = table.Column<int>(type: "int", nullable: false),
                    ZapreminaMotora = table.Column<int>(type: "int", nullable: false),
                    Snaga = table.Column<int>(type: "int", nullable: false),
                    Gorivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Karoserija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotografija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cijena = table.Column<int>(type: "int", nullable: false),
                    Kontakt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Cijena", "Fotografija", "Godiste", "Gorivo", "Karoserija", "Kontakt", "Marka", "Model", "Opis", "Snaga", "ZapreminaMotora" },
                values: new object[] { 1, 9600, "octavia.jpg", 2015, "dizel", "Sedan", "067440040", "Skoda", "Octavia", "Auto je u odlicnom stanju. Ima Full opremu", 110, 1600 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Cijena", "Fotografija", "Godiste", "Gorivo", "Karoserija", "Kontakt", "Marka", "Model", "Opis", "Snaga", "ZapreminaMotora" },
                values: new object[] { 2, 11800, "captur.jpg", 2017, "benzin", "SUV", "067197007", "Renault", "Capture", "Automatik, nove gume, full oprema", 98, 1500 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Cijena", "Fotografija", "Godiste", "Gorivo", "Karoserija", "Kontakt", "Marka", "Model", "Opis", "Snaga", "ZapreminaMotora" },
                values: new object[] { 3, 9000, "rio.jpg", 2018, "hibrid", "karavan", "069635869", "Kia", "Rio", "Auto je u odlicnom stanju. Ima Full opremu", 130, 1500 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
