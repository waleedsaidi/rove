using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Rova.Mobile.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _welcomeMessage;

        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set
            {
                if (_welcomeMessage != value)
                {
                    _welcomeMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        public HomeViewModel()
        {
            WelcomeMessage = "Welcome to Rova Workshop!";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}