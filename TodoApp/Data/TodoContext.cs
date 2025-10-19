using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }

        // Seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = new Guid("96210f93-0139-4467-873b-248356980e14"),
                    Title = "Learn Blazor",
                    IsDone = true
                },
                new TodoItem
                {
                    Id = new Guid("468d6f93-0239-4981-8b7a-e390c427301c"),
                    Title = "Build this Todo App",
                    IsDone = false
                },
                new TodoItem
                {
                    Id = new Guid("c3f0c2a2-4a0b-4652-9e6b-a15d045d44cc"),
                    Title = "Deploy to Azure",
                    IsDone = false
                },
                new TodoItem
                {
                    Id = new Guid("d147a4c5-031f-431e-b81b-5f09673994c1"),
                    Title = "Configure Tailwind CSS",
                    IsDone = false
                },
        new TodoItem
        {
            Id = new Guid("4b12c6a0-e6f8-4e89-8b83-2d939e6a0d4c"),
            Title = "Design the main Blazor component",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("5c69b2d8-21f4-4a7b-a0f1-41712c4b7b3b"),
            Title = "Write unit tests for TodoService",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("8e20f0e3-3e1c-4b3f-8a0a-0402e6002f2d"),
            Title = "Set up CI/CD pipeline",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("f67c3b9a-4d7a-4c2b-b8f3-490f84a5e3c7"),
            Title = "Read documentation on C# 12 features",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("1a58c1f0-58d3-4e6a-8d7e-0730b2e8a1f4"),
            Title = "Refactor existing application services",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("6e0c7e2d-6b1a-4c9f-8d2b-67a3f81e7d0a"),
            Title = "Implement drag-and-drop for task ordering",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("c9f0d1a4-7a3b-4e5c-9d4e-18f6c4d7b9e0"),
            Title = "Review pull requests from teammates",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("7d2e8b0a-8c9d-4e1f-a3b0-27c5e9f8a1d2"),
            Title = "Create a database backup script",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("4b5c6d7e-9f0a-4b1c-8e2d-3a4f5b6c7d8e"),
            Title = "Research state management alternatives (e.g., Flux)",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("2f9e4d1c-a0b1-4c3e-9d5f-4b6c7d8e9f0a"),
            Title = "Attend the morning stand-up meeting",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("3a8b4c5d-b1c2-4e6f-9d7a-5f8b9c0d1e2f"),
            Title = "Fix critical bug in authentication module",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("5c7d8e9f-c2d3-4f0a-a1b2-6e9f0a1b2c3d"),
            Title = "Write documentation for new API endpoint",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("7e9f0a1b-d3e4-4c2d-b8a3-7f0a1b2c3d4e"),
            Title = "Configure logging to Azure Application Insights",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("8f0a1b2c-e4f5-4d3e-c9b0-8a1b2c3d4e5f"),
            Title = "Test responsive layout on mobile devices",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("a1b2c3d4-f5a6-4e5c-9d6e-9b2c3d4e5f6a"),
            Title = "Optimize database queries for performance",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("c3d4e5f6-a7b8-4c6d-b8e7-a1d2e3f4a5b6"),
            Title = "Prepare presentation for team meeting",
            IsDone = true
        },
        new TodoItem
        {
            Id = new Guid("e5f6a7b8-c9d0-4e7f-a0b1-b2c3d4e5f6a7"),
            Title = "Set up git hooks for automatic formatting",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("0d1e2f3a-d0e1-4f8a-9b1c-c3d4e5f6a7b8"),
            Title = "Order new monitors for the development team",
            IsDone = false
        },
        new TodoItem
        {
            Id = new Guid("2b3c4d5e-e1f2-4e9f-a2c3-d4e5f6a7b8c9"),
            Title = "Review security policy documentation",
            IsDone = true
        }
            );
        }
    }
}
