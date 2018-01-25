using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo2.Entities;
using Todo2.Models;

namespace Todo2.Repositories
{
    public class TodoRepository
    {
        public TodoContext TodoContext { get; set; }

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> ListOfToDos()
        {
            List<Todo> ListOfToDos = new List<Todo>();

            foreach (var item in TodoContext.Todos)
            {
                ListOfToDos.Add(item);
            }

            return ListOfToDos;
        }

        public void AddTodo(Todo todo)
        {
            TodoContext.Add(todo);
            TodoContext.SaveChanges();
        }
    }
}
