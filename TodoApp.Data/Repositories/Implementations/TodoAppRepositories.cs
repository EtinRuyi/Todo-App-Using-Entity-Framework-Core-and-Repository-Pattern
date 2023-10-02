using Microsoft.EntityFrameworkCore;
using TodoApp.Data.Repositories.Interfaces;
using TodoApp.Model;

namespace TodoApp.Data.Repositories.Implementations
{
    public class TodoAppRepositories : ITodoAppRepositories
    {
        private readonly TodoAppDBContext _context;

        public TodoAppRepositories(TodoAppDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<TodoItem> GetTodoAppItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetById(int id)
        {
            return _context.TodoItems.FirstOrDefault(item => item.Id == id);
        }

        public void Add(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public void Update(TodoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDoListItem = GetById(id);
            if (toDoListItem != null)
            {
                _context.TodoItems.Remove(toDoListItem);
                _context.SaveChanges();
            }
        }

        public void ResetAutoIncrement()
        {
            string tableName = "TodoItems";
            string resetSql = $"DBCC CHECKIDENT ('{tableName}', RESEED, 0);";
            _context.Database.ExecuteSqlRaw(resetSql);
        }

    }
}
