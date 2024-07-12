using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManager.Server.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32952a09-675a-4f20-86e0-fc20f87c643f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e357f207-30a6-41e4-b65d-723f9033c876");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b5ae7b8-39c4-4308-9b11-c4fd4a8e5ba1", "2b5ae7b8-39c4-4308-9b11-c4fd4a8e5ba1", "Admin", "ADMIN" },
                    { "b91d1fc0-8d45-4bd2-a7b5-8c525b07675d", "b91d1fc0-8d45-4bd2-a7b5-8c525b07675d", "Student", "STUDENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5ae7b8-39c4-4308-9b11-c4fd4a8e5ba1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b91d1fc0-8d45-4bd2-a7b5-8c525b07675d");

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32952a09-675a-4f20-86e0-fc20f87c643f", "32952a09-675a-4f20-86e0-fc20f87c643f", "Admin", "ADMIN" },
                    { "e357f207-30a6-41e4-b65d-723f9033c876", "e357f207-30a6-41e4-b65d-723f9033c876", "Student", "STUDENT" }
                });
        }
    }
}
