using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;
using Xamarin.Forms;

namespace Rova.Mobile.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        private readonly ICustomerService _customerService;
        public ObservableCollection<CustomerModel> Customers { get; set; }
        public ICommand LoadCustomersCommand { get; }

        public CustomersViewModel(ICustomerService customerService)
        {
            _customerService = customerService;
            Customers = new ObservableCollection<CustomerModel>();
            LoadCustomersCommand = new Command(async () => await LoadCustomers());
        }

        private async Task LoadCustomers()
        {
            var customers = await _customerService.GetCustomersAsync();
            Customers.Clear();
            foreach (var customer in customers)
            {
                Customers.Add(customer);
            }
        }
    }
}