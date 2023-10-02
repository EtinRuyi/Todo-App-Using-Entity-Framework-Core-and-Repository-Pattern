using Microsoft.EntityFrameworkCore;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class TodoAppDBContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public TodoAppDBContext() : base()
        {
        }

        public TodoAppDBContext(DbContextOptions<TodoAppDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TodoAppDB;Integrated Security=True;Encrypt = False ");
        }
    }
}
