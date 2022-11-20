using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace site.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Inititial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[,]
                {
                    { 1, "http://blogs.packtpub.com/dotnet" },
                    { 2, "http://blogs.packtpub.com/dotnetcore" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "PublishedDateTime", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Dotnet 4.7 Released Contents", new DateTime(2022, 11, 20, 19, 19, 51, 744, DateTimeKind.Local).AddTicks(4324), "Dotnet 4.7 Released" },
                    { 2, 1, ".NET Core 1.1 Released Contents", new DateTime(2022, 11, 20, 19, 19, 51, 744, DateTimeKind.Local).AddTicks(4344), ".NET Core 1.1 Released" },
                    { 3, 2, "EF Core 1.1 Released Contents", new DateTime(2022, 11, 20, 19, 19, 51, 744, DateTimeKind.Local).AddTicks(4346), "EF Core 1.1 Released" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2);
        }
    }
}
