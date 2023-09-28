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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new ToDoListForm());

            var optionsBuilder = new DbContextOptionsBuilder<TodoAppDBContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TodoAppDB;Integrated Security=True;Encrypt = False"); // Replace with your connection string

            // Create the DbContext instance
            using (var dbContext = new TodoAppDBContext(optionsBuilder.Options))
            {
                // Ensure the database is created and migrations are applied
                dbContext.Database.Migrate();

                // Create the services and forms using Dependency Injection
                var serviceProvider = ConfigureServices(dbContext);

                // Create and run the main form
                using (var toDoListForm = serviceProvider.GetRequiredService<TodoApp>())
                {
                    System.Windows.Forms.Application.Run(toDoListForm);
                }
            }
        }

        private static IServiceProvider ConfigureServices(TodoAppDBContext dbContext)
        {
            // Configure Dependency Injection
            var services = new ServiceCollection();

            // Register DbContext and repositories
            services.AddSingleton(dbContext);
            services.AddScoped<ITodoAppRepositories, TodoAppRepositories>();

            // Register services
            services.AddScoped<TodoAppService>();

            // Register the main form
            services.AddTransient<TodoApp>();

            return services.BuildServiceProvider();
        }
    }
}