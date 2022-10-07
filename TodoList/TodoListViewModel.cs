using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace TodoList
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("eat cake",false));
            TodoItems.Add(new TodoItem("clean plate", true));
            TodoItems.Add(new TodoItem("put plate away", false));
        }
    }
}
