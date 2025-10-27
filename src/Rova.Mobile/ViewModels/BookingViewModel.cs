using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;
using Xamarin.Forms;

namespace Rova.Mobile.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        private readonly IBookingService _bookingService;
        private ObservableCollection<ServiceModel> _services;
        private ServiceModel _selectedService;
        private DateTime _selectedDate;
        private TimeSpan _selectedTime;

        public BookingViewModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
            Services = new ObservableCollection<ServiceModel>();
            LoadServicesCommand = new Command(async () => await LoadServices());
            BookServiceCommand = new Command(async () => await BookService());
        }

        public ObservableCollection<ServiceModel> Services
        {
            get => _services;
            set => SetProperty(ref _services, value);
        }

        public ServiceModel SelectedService
        {
            get => _selectedService;
            set => SetProperty(ref _selectedService, value);
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        public TimeSpan SelectedTime
        {
            get => _selectedTime;
            set => SetProperty(ref _selectedTime, value);
        }

        public ICommand LoadServicesCommand { get; }
        public ICommand BookServiceCommand { get; }

        private async System.Threading.Tasks.Task LoadServices()
        {
            var services = await _bookingService.GetAvailableServices();
            Services.Clear();
            foreach (var service in services)
            {
                Services.Add(service);
            }
        }

        private async System.Threading.Tasks.Task BookService()
        {
            if (SelectedService == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please select a service.", "OK");
                return;
            }

            var booking = new BookingModel
            {
                ServiceId = SelectedService.Id,
                Date = SelectedDate,
                Time = SelectedTime
            };

            var result = await _bookingService.BookService(booking);
            if (result)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Your booking has been confirmed.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Failed to book the service. Please try again.", "OK");
            }
        }
    }
}