using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

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
        //Add
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoInputVal { get; set; }
        
        void AddTodoItem()
        {
            //Console.Write("Enter Pressed");
            if (NewTodoInputVal.Replace(" ","") == "") return;
            TodoItems.Add(new TodoItem(NewTodoInputVal.Trim(), false));
            

        }
        //Remove
        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem  todoItemBeingRemoved  = o as TodoItem;
            //Console.Write("Removing");
            TodoItems.Remove(todoItemBeingRemoved);
        }

    }
}
