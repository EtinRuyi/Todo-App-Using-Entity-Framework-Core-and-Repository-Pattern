using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Core.Services;
using TodoApp.Data;
using TodoApp.Data.Repositories.Implementations;
using TodoApp.Data.Repositories.Interfaces;

namespace TodoApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var optionsBuilder = new DbContextOptionsBuilder<TodoAppDBContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TodoAppDB;Integrated Security=True;Encrypt=False");

            using (var dbContext = new TodoAppDBContext(optionsBuilder.Options))
            {
                dbContext.Database.Migrate();

                var serviceProvider = ConfigureServices(dbContext);

                using (var toDoListForm = serviceProvider.GetRequiredService<TodoApp>())
                {
                    System.Windows.Forms.Application.Run(toDoListForm);
                }
            }
        }

        private static IServiceProvider ConfigureServices(TodoAppDBContext dbContext)
        {
            var services = new ServiceCollection();
            services.AddSingleton(dbContext);
            services.AddScoped<ITodoAppRepositories, TodoAppRepositories>();
            services.AddScoped<TodoAppService>();
            services.AddTransient<TodoApp>();
            return services.BuildServiceProvider();
        }
    }
}
