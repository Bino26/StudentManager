using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManager.Server.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    { new Guid("14052602-070b-4c1b-a46c-3c82f73b92f3"), "5B", "marc.durand@collegesjb.com", "Marc Durand" },
                    { new Guid("1ebef7d0-c88e-4891-9565-0e7e91200f42"), "5D", "isabelle.francois@collegesjb.com", "Isabelle Francois" },
                    { new Guid("1fa723e0-5427-4d6b-8110-e6b896d5b7f4"), "1D", "victor.leger@collegesjb.com", "Victor Leger" },
                    { new Guid("27f9bd03-5e1e-43e8-8a43-b997d44c925a"), "3A", "thomas.richard@collegesjb.com", "Thomas Richard" },
                    { new Guid("2a387738-8b64-4bde-a830-2c71c3330cb1"), "2B", "emma.michel@collegesjb.com", "Emma Michel" },
                    { new Guid("2b041f44-9c5c-4f30-b959-1f7aef3bc1e6"), "5A", "julien.vincent@collegesjb.com", "Julien Vincent" },
                    { new Guid("6b021295-b304-41bb-b768-d8849df1c01c"), "3D", "hugo.dupuis@collegesjb.com", "Hugo Dupuis" },
                    { new Guid("6c18e9f8-edbe-400c-9b76-c556301fd663"), "3C", "julie.martin@collegesjb.com", "Julie Martin" },
                    { new Guid("77700417-a71e-4bea-baf4-b942d18b85a6"), "5C", "lucie.petit@collegesjb.com", "Lucie Petit" },
                    { new Guid("83dcc397-5bec-4ec8-9703-7237ee67f9ae"), "4D", "mathieu.chevalier@collegesjb.com", "Mathieu Chevalier" },
                    { new Guid("98329043-10e1-4bf3-afd4-e818f8fb9b10"), "2A", "camille.fontaine@collegesjb.com", "Camille Fontaine" },
                    { new Guid("a0f1b5ae-6ee4-4317-9226-a788bd95339d"), "3B", "manon.garnier@collegesjb.com", "Manon Garnier" },
                    { new Guid("a3915e85-7802-4d4e-b19f-f822b3f8b887"), "4B", "paul.moreau@collegesjb.com", "Paul Moreau" },
                    { new Guid("a4dfffdc-f0ce-4c6c-9dd2-efbcd1448d71"), "1A", "sophie.lefevre@collegesjb.com", "Sophie Lefevre" },
                    { new Guid("c1f5e8e9-b954-448c-928e-e026f811b4e9"), "2D", "pierre.dubois@collegesjb.com", "Pierre Dubois" },
                    { new Guid("d015be9a-3e37-40fe-8b6b-09676ab98bed"), "1B", "elodie.fournier@collegesjb.com", "Elodie Fournier" },
                    { new Guid("e13bc5e4-772c-4491-8882-be87f2c85333"), "2C", "nicolas.lambert@collegesjb.com", "Nicolas Lambert" },
                    { new Guid("ecd5affb-8b4d-4a88-a1df-c4fcdc483ac8"), "4A", "alice.dupont@collegesjb.com", "Alice Dupont" },
                    { new Guid("ef263000-3f2e-4634-9f9f-e11f6204c10b"), "4C", "claire.roux@collegesjb.com", "Claire Roux" },
                    { new Guid("f6a8c6e6-961b-4c94-b1a4-7891c1821a45"), "1C", "antoine.leroy@collegesjb.com", "Antoine Leroy" }
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
