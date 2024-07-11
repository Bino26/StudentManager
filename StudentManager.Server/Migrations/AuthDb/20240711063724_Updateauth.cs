using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManager.Server.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Updateauth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6573e59-068c-4ee7-91d7-4ec92ca5e11c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5dfcc60-ff9f-4aa2-a01b-f3f43c2e7496");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8899aba6-4d67-49b3-8a6b-481cfff6b68c", "8899aba6-4d67-49b3-8a6b-481cfff6b68c", "Student", "STUDENT" },
                    { "b45e019f-7d1a-4dec-a5d6-49791609c897", "b45e019f-7d1a-4dec-a5d6-49791609c897", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8899aba6-4d67-49b3-8a6b-481cfff6b68c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b45e019f-7d1a-4dec-a5d6-49791609c897");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a6573e59-068c-4ee7-91d7-4ec92ca5e11c", "a6573e59-068c-4ee7-91d7-4ec92ca5e11c", "Reader", "READER" },
                    { "b5dfcc60-ff9f-4aa2-a01b-f3f43c2e7496", "b5dfcc60-ff9f-4aa2-a01b-f3f43c2e7496", "Writer", "WRITER" }
                });
        }
    }
}
