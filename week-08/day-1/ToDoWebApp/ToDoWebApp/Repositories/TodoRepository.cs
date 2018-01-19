using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ToDoWebApp.Repositories
{
    public class TodoRepository
    {
        public TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

    }
}
