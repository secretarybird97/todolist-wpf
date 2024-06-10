using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using todolist_wpf.Models;

namespace todolist_wpf.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ToDoListViewModel(IEnumerable<ToDoItem> items)
        {
            ListItems = new ObservableCollection<ToDoItem>(items);
        }

        public ObservableCollection<ToDoItem> ListItems { get; }
    }
}
