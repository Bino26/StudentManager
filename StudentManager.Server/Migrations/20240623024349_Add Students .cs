using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManager.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("12365773-3c0c-412a-9310-4d4ff5f2c28c"), "2B", "emma.michel@collegesjb.com", "Emma Michel" },
                    { new Guid("152af75b-e25d-4a03-a8f5-7c2161293e31"), "5A", "julien.vincent@collegesjb.com", "Julien Vincent" },
                    { new Guid("1e8d9c2f-a2f0-40f4-a743-ac3a13d2fba8"), "1D", "victor.leger@collegesjb.com", "Victor Leger" },
                    { new Guid("216c635f-8d1e-4f60-9fac-f94774fe0a31"), "4B", "paul.moreau@collegesjb.com", "Paul Moreau" },
                    { new Guid("21a975b0-7dd8-4502-ba9d-e51f3c825ffd"), "3D", "hugo.dupuis@collegesjb.com", "Hugo Dupuis" },
                    { new Guid("3e57428b-2a9b-4d65-aa74-35d42342ca2d"), "1A", "sophie.lefevre@collegesjb.com", "Sophie Lefevre" },
                    { new Guid("4baa3bdc-4994-4290-9f2b-10b8d0bbae09"), "2D", "pierre.dubois@collegesjb.com", "Pierre Dubois" },
                    { new Guid("4f8b41b1-eaab-476b-b059-d6295aa3eea4"), "2C", "nicolas.lambert@collegesjb.com", "Nicolas Lambert" },
                    { new Guid("5fef2dc4-f057-4870-9f49-04cf532898ef"), "4C", "claire.roux@collegesjb.com", "Claire Roux" },
                    { new Guid("678bf73e-dd68-47d3-9e86-be0dd9448b4d"), "3B", "manon.garnier@collegesjb.com", "Manon Garnier" },
                    { new Guid("7102fe8e-9b84-491b-83fa-ee28a2b548ba"), "5D", "isabelle.francois@collegesjb.com", "Isabelle Francois" },
                    { new Guid("732929b4-52a3-4a88-b01e-6216fe245c4f"), "1C", "antoine.leroy@collegesjb.com", "Antoine Leroy" },
                    { new Guid("78ee9f65-9a9b-4efb-a15e-24b9a182f7e3"), "5B", "marc.durand@collegesjb.com", "Marc Durand" },
                    { new Guid("7af00511-ffd0-441a-a24d-7f72e556ded4"), "4D", "mathieu.chevalier@collegesjb.com", "Mathieu Chevalier" },
                    { new Guid("80726ec6-8ac2-4134-b964-7ab5a4d47b5a"), "5C", "lucie.petit@collegesjb.com", "Lucie Petit" },
                    { new Guid("a0ee8ac8-bc05-4bd1-a96d-61bd16c0614b"), "4A", "alice.dupont@collegesjb.com", "Alice Dupont" },
                    { new Guid("a7a023b2-df66-4c67-9a03-9d7c677abfc1"), "2A", "camille.fontaine@collegesjb.com", "Camille Fontaine" },
                    { new Guid("abacf5de-d7a4-4c01-a5ee-091bf9e39ada"), "1B", "elodie.fournier@collegesjb.com", "Elodie Fournier" },
                    { new Guid("e09519f0-735d-4f85-95f5-f564e5b2fae9"), "3A", "thomas.richard@collegesjb.com", "Thomas Richard" },
                    { new Guid("f1977078-d508-4a6a-b0fb-07435d3b80b0"), "3C", "julie.martin@collegesjb.com", "Julie Martin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
