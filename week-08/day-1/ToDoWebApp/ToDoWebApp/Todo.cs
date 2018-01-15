using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWebApp
{
    public class Todo
    {
        //(Id:long, Title:string, IsUrgent:boolean(default false), IsDone:boolean(default false

        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }

    }
}
