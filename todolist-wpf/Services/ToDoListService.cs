using System.Collections.Generic;
using todolist_wpf.Models;

namespace todolist_wpf.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem() { Description = "Buy milk", IsDone = false },
            new ToDoItem() { Description = "Buy bread", IsDone = true },
            new ToDoItem() { Description = "Buy cheese", IsDone = false }
        };
    }
}
