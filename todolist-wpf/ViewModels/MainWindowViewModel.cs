using System;
using System.Windows.Input;
using todolist_wpf.Services;

namespace todolist_wpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _contentViewModel;
        public ICommand AddItemCommand { get; }
        public MainWindowViewModel()
        {
            var service = new ToDoListService();
            ToDoListViewModel = new ToDoListViewModel(service.GetItems());
            _contentViewModel = ToDoListViewModel;
            AddItemCommand = new RelayCommand(AddItem);
        }
        public ToDoListViewModel ToDoListViewModel { get; }

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            set
            {
                _contentViewModel = value;
                OnPropertyChanged(nameof(ContentViewModel));
            }
        }

        public void AddItem()
        {
            ContentViewModel = new AddItemViewModel();
        }

        public class RelayCommand : ICommand
        {
            private readonly Action _execute;

            public RelayCommand(Action execute)
            {
                _execute = execute;
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter) => true;

            public void Execute(object parameter) => _execute();
        }

    }
}
