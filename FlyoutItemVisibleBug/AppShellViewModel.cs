using System.ComponentModel;

namespace FlyoutItemVisibleBug
{
    public class AppShellViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public AppShellViewModel()
        {
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private bool showItem;
        public bool ShowItem
        {
            get => showItem;
            set
            {
                showItem = value;
                OnPropertyChanged(nameof(ShowItem));
            }
        }
    }
}
