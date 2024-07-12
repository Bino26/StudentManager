using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManager.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invitations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitations", x => x.Id);
                });

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
                    { new Guid("011f2fef-6f2e-478b-a94d-c488069532de"), "3C", "julie.martin@collegesjb.com", "Julie Martin" },
                    { new Guid("12ed66e9-a25e-4970-957b-bb3f80e360b4"), "2C", "nicolas.lambert@collegesjb.com", "Nicolas Lambert" },
                    { new Guid("3f65e3de-16eb-4bb6-82a6-e7d603449a94"), "4A", "alice.dupont@collegesjb.com", "Alice Dupont" },
                    { new Guid("56e20f47-4eb1-4a1d-98b4-519d9071f7cf"), "1A", "sophie.lefevre@collegesjb.com", "Sophie Lefevre" },
                    { new Guid("5feab2a2-4657-43f1-be4d-fd959811970f"), "2B", "emma.michel@collegesjb.com", "Emma Michel" },
                    { new Guid("60e659df-c66f-471c-a309-7a0ef5caf751"), "3B", "manon.garnier@collegesjb.com", "Manon Garnier" },
                    { new Guid("6d937347-4a51-4073-bb51-f8e2a5a08b3c"), "4B", "paul.moreau@collegesjb.com", "Paul Moreau" },
                    { new Guid("6f1138a2-68f6-4e60-ab28-e2c81ed2611d"), "4D", "mathieu.chevalier@collegesjb.com", "Mathieu Chevalier" },
                    { new Guid("758dbf89-3c46-4d71-b5b4-e5aaf3219ab8"), "5A", "julien.vincent@collegesjb.com", "Julien Vincent" },
                    { new Guid("7b9896f9-c46e-405b-8d66-d8fdf6d4aa83"), "4C", "claire.roux@collegesjb.com", "Claire Roux" },
                    { new Guid("875b59f1-75c4-49f4-82c1-44f8d36bece8"), "5C", "lucie.petit@collegesjb.com", "Lucie Petit" },
                    { new Guid("9a6b72e8-cfd3-4d06-8919-1fe53b71c764"), "3A", "thomas.richard@collegesjb.com", "Thomas Richard" },
                    { new Guid("a743348c-b309-4e41-8e65-68808bbdbd51"), "2D", "pierre.dubois@collegesjb.com", "Pierre Dubois" },
                    { new Guid("b3d164aa-e473-47b1-8c51-93fa631813da"), "3D", "hugo.dupuis@collegesjb.com", "Hugo Dupuis" },
                    { new Guid("ba4c1c16-564c-4451-a36e-09e5fae65bb9"), "1B", "elodie.fournier@collegesjb.com", "Elodie Fournier" },
                    { new Guid("c355730c-38e4-44a9-b649-ef3730f3d889"), "5D", "isabelle.francois@collegesjb.com", "Isabelle Francois" },
                    { new Guid("c3c426d7-452f-4991-be34-1e513c1cea16"), "1C", "antoine.leroy@collegesjb.com", "Antoine Leroy" },
                    { new Guid("cabfd1ef-3528-401c-9ea5-80de0fff6724"), "1D", "victor.leger@collegesjb.com", "Victor Leger" },
                    { new Guid("cf78b21b-f7f2-40c0-8a19-81e32c3e90e7"), "2A", "camille.fontaine@collegesjb.com", "Camille Fontaine" },
                    { new Guid("de29a3e0-3c93-4118-9001-eb8d148f548b"), "5B", "marc.durand@collegesjb.com", "Marc Durand" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invitations");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
