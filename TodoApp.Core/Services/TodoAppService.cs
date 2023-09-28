using TodoApp.Data;
using TodoApp.Model;

namespace TodoApp.Core.Services
{
    public class TodoAppService
    {
        private readonly TodoAppDBContext _context;

        public TodoAppService(TodoAppDBContext context)
        {
            _context = context;
        }

        public void AddTodoItem(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public void UpdateTodoItem(TodoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }

        public void DeleteTodoItem(int id)
        {
            var toDoListItem = _context.TodoItems.FirstOrDefault(item => item.Id == id);
            if (toDoListItem != null)
            {
                _context.TodoItems.Remove(toDoListItem);
                _context.SaveChanges();
            }
        }

        public List<TodoItem> GetAllTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetTodoItemById(int id)
        {
            return _context.TodoItems.FirstOrDefault(item => item.Id == id);
        }
    }
}
