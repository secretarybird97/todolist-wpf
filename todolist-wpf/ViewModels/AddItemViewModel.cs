using System;

namespace todolist_wpf.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        private string _description = String.Empty;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }
}
