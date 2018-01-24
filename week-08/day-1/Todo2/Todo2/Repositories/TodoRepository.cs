using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo2.Entities;

namespace Todo2.Repositories
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
