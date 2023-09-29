//using TodoApp.Model;

//namespace TodoApp.Data.Repositories.Interfaces
//{
//    public interface ITodoAppRepositories
//    {
//        List<TodoItem> GetTodoAppItems();
//        TodoItem GetById(int id);
//        void Add(TodoItem item);
//        void Update(TodoItem item);
//        void Delete(int id);
//    }
//}



using System.Collections.Generic;
using TodoApp.Model;

namespace TodoApp.Data.Repositories.Interfaces
{
    public interface ITodoAppRepositories
    {
        List<TodoItem> GetTodoAppItems();
        TodoItem GetById(int id);
        void Add(TodoItem item);
        void Update(TodoItem item);
        void Delete(int id);

        // Define the ResetAutoIncrement method
        void ResetAutoIncrement();
    }
}
