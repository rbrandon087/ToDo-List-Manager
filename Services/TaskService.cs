using System.Collections.Generic;
using TodoTask.Models;

namespace Todo.list
{
    public interface TaskService
    {
        IEnumerable<TodoTask> GetAll();
        TodoTask GetById(int id);
        void Add(TodoTask item);
        void Update(TodoTask item);
        void Delete(int id);
    }

    public class TodoService : ITodoService
    {

    }
}