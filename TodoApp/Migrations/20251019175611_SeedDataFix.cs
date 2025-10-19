using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("753b4237-95c9-4f31-a294-b5fc32c08f6c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8ed449be-1d54-4288-8b91-ea97756ab986"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("bae8c9e1-a412-4af8-8a03-d50a0a92df27"));

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsDone", "Title" },
                values: new object[,]
                {
                    { new Guid("468d6f93-0239-4981-8b7a-e390c427301c"), false, "Build this Todo App" },
                    { new Guid("96210f93-0139-4467-873b-248356980e14"), true, "Learn Blazor" },
                    { new Guid("c3f0c2a2-4a0b-4652-9e6b-a15d045d44cc"), false, "Deploy to Azure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("468d6f93-0239-4981-8b7a-e390c427301c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("96210f93-0139-4467-873b-248356980e14"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c3f0c2a2-4a0b-4652-9e6b-a15d045d44cc"));

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsDone", "Title" },
                values: new object[,]
                {
                    { new Guid("753b4237-95c9-4f31-a294-b5fc32c08f6c"), false, "Build this Todo App" },
                    { new Guid("8ed449be-1d54-4288-8b91-ea97756ab986"), false, "Deploy to Azure" },
                    { new Guid("bae8c9e1-a412-4af8-8a03-d50a0a92df27"), true, "Learn Blazor" }
                });
        }
    }
}
