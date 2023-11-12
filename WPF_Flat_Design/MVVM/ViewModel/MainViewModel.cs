using WPF_Flat_Design.Core;

namespace WPF_Flat_Design.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;
        }
    }
}
