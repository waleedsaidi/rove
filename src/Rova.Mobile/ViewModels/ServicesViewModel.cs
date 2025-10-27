using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;

namespace Rova.Mobile.ViewModels
{
    public class ServicesViewModel : BaseViewModel
    {
        private readonly IServiceService _serviceService;
        private ObservableCollection<ServiceModel> _services;

        public ObservableCollection<ServiceModel> Services
        {
            get => _services;
            set => SetProperty(ref _services, value);
        }

        public ICommand LoadServicesCommand { get; }

        public ServicesViewModel(IServiceService serviceService)
        {
            _serviceService = serviceService;
            LoadServicesCommand = new Command(async () => await LoadServices());
            Services = new ObservableCollection<ServiceModel>();
        }

        private async Task LoadServices()
        {
            IsBusy = true;

            try
            {
                var services = await _serviceService.GetServicesAsync();
                Services.Clear();
                foreach (var service in services)
                {
                    Services.Add(service);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., show a message to the user)
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}