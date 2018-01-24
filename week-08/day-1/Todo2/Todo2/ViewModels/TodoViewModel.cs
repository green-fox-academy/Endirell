using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo2.Models;

namespace Todo2.ViewModels
{
    public class TodoViewModel
    {
        public List<Todo> TodoList { get; set; } = new List<Todo>();
    }
}
