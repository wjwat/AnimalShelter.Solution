using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Breed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Breed", "Description", "Name", "Species", "Status" },
                values: new object[,]
                {
                    { 1, "I dunno, cat", "Fat & mean, you'll love him.", "Steve", "Cat", 1 },
                    { 2, "Beagle", "Just one of the worst dogs, but also one of the best? A study in contradictions.", "Six Hotdogs", "Dog", 2 },
                    { 3, "Chihuahua", "Annoying, mean, won't stop shaking, growls at everything, please help us", "Toes under the escalator", "Dog", 1 },
                    { 4, "Fat", "Queen Salt has to have her chicken precisely at 5pm or you will get scratched. She has thumbs!", "Salt", "Cat", 2 },
                    { 5, "Dachshund", "Loves a good burger", "Whataburger", "Dog", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
