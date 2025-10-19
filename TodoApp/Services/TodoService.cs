using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService
    {
        private readonly TodoContext _context;

        public TodoService(TodoContext context)
        {
            _context = context;
        }

        // We will add our methods here (GetAllAsync, AddTaskAsync, etc.)
        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // NEW METHOD: Add a new task to the database
        public async Task AddTaskAsync(string title)
        {
            // Create a new TodoItem object
            var newTask = new TodoItem
            {
                Id = Guid.NewGuid(),      // Generate a unique ID
                Title = title,             // Set the title from parameter
                IsDone = false             // New tasks are always incomplete
            };

            // Add the new task to the DbContext (in-memory, not yet in database)
            _context.TodoItems.Add(newTask);

            // Save changes to the database (this actually writes to SQL Server)
            await _context.SaveChangesAsync();
        }

        // NEW METHOD: Update an existing task
        public async Task UpdateTaskAsync(TodoItem item)
        {
            // Attach the item to the DbContext
            // (tells EF: "I want to track this object")
            _context.Attach(item);

            // Mark the entity's state as Modified
            // (tells EF: "this object has changes that need to be saved")
            _context.Entry(item).State = EntityState.Modified;

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }
}
