using TodoApp.Data;

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
    }
}
