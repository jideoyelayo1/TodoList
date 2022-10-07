using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    public class TodoItem
    {
        public string TodoText { get; set; }
        public bool Completed { get; set; }
        public TodoItem(string TodoText, bool Completed)
        {
            this.TodoText = TodoText;
            this.Completed = Completed;
        }
    }
}
