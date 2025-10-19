using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsDone", "Title" },
                values: new object[,]
                {
                    { new Guid("0d1e2f3a-d0e1-4f8a-9b1c-c3d4e5f6a7b8"), false, "Order new monitors for the development team" },
                    { new Guid("1a58c1f0-58d3-4e6a-8d7e-0730b2e8a1f4"), true, "Refactor existing application services" },
                    { new Guid("2b3c4d5e-e1f2-4e9f-a2c3-d4e5f6a7b8c9"), true, "Review security policy documentation" },
                    { new Guid("2f9e4d1c-a0b1-4c3e-9d5f-4b6c7d8e9f0a"), true, "Attend the morning stand-up meeting" },
                    { new Guid("3a8b4c5d-b1c2-4e6f-9d7a-5f8b9c0d1e2f"), false, "Fix critical bug in authentication module" },
                    { new Guid("4b12c6a0-e6f8-4e89-8b83-2d939e6a0d4c"), false, "Design the main Blazor component" },
                    { new Guid("4b5c6d7e-9f0a-4b1c-8e2d-3a4f5b6c7d8e"), false, "Research state management alternatives (e.g., Flux)" },
                    { new Guid("5c69b2d8-21f4-4a7b-a0f1-41712c4b7b3b"), true, "Write unit tests for TodoService" },
                    { new Guid("5c7d8e9f-c2d3-4f0a-a1b2-6e9f0a1b2c3d"), false, "Write documentation for new API endpoint" },
                    { new Guid("6e0c7e2d-6b1a-4c9f-8d2b-67a3f81e7d0a"), false, "Implement drag-and-drop for task ordering" },
                    { new Guid("7d2e8b0a-8c9d-4e1f-a3b0-27c5e9f8a1d2"), true, "Create a database backup script" },
                    { new Guid("7e9f0a1b-d3e4-4c2d-b8a3-7f0a1b2c3d4e"), true, "Configure logging to Azure Application Insights" },
                    { new Guid("8e20f0e3-3e1c-4b3f-8a0a-0402e6002f2d"), false, "Set up CI/CD pipeline" },
                    { new Guid("8f0a1b2c-e4f5-4d3e-c9b0-8a1b2c3d4e5f"), false, "Test responsive layout on mobile devices" },
                    { new Guid("a1b2c3d4-f5a6-4e5c-9d6e-9b2c3d4e5f6a"), true, "Optimize database queries for performance" },
                    { new Guid("c3d4e5f6-a7b8-4c6d-b8e7-a1d2e3f4a5b6"), true, "Prepare presentation for team meeting" },
                    { new Guid("c9f0d1a4-7a3b-4e5c-9d4e-18f6c4d7b9e0"), false, "Review pull requests from teammates" },
                    { new Guid("d147a4c5-031f-431e-b81b-5f09673994c1"), false, "Configure Tailwind CSS" },
                    { new Guid("e5f6a7b8-c9d0-4e7f-a0b1-b2c3d4e5f6a7"), false, "Set up git hooks for automatic formatting" },
                    { new Guid("f67c3b9a-4d7a-4c2b-b8f3-490f84a5e3c7"), true, "Read documentation on C# 12 features" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("0d1e2f3a-d0e1-4f8a-9b1c-c3d4e5f6a7b8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1a58c1f0-58d3-4e6a-8d7e-0730b2e8a1f4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2b3c4d5e-e1f2-4e9f-a2c3-d4e5f6a7b8c9"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2f9e4d1c-a0b1-4c3e-9d5f-4b6c7d8e9f0a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3a8b4c5d-b1c2-4e6f-9d7a-5f8b9c0d1e2f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4b12c6a0-e6f8-4e89-8b83-2d939e6a0d4c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4b5c6d7e-9f0a-4b1c-8e2d-3a4f5b6c7d8e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5c69b2d8-21f4-4a7b-a0f1-41712c4b7b3b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5c7d8e9f-c2d3-4f0a-a1b2-6e9f0a1b2c3d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6e0c7e2d-6b1a-4c9f-8d2b-67a3f81e7d0a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7d2e8b0a-8c9d-4e1f-a3b0-27c5e9f8a1d2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7e9f0a1b-d3e4-4c2d-b8a3-7f0a1b2c3d4e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8e20f0e3-3e1c-4b3f-8a0a-0402e6002f2d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8f0a1b2c-e4f5-4d3e-c9b0-8a1b2c3d4e5f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-f5a6-4e5c-9d6e-9b2c3d4e5f6a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c3d4e5f6-a7b8-4c6d-b8e7-a1d2e3f4a5b6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c9f0d1a4-7a3b-4e5c-9d4e-18f6c4d7b9e0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d147a4c5-031f-431e-b81b-5f09673994c1"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e5f6a7b8-c9d0-4e7f-a0b1-b2c3d4e5f6a7"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f67c3b9a-4d7a-4c2b-b8f3-490f84a5e3c7"));
        }
    }
}
