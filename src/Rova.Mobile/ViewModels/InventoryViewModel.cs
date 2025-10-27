using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Rova.Mobile.ViewModels
{
    public partial class InventoryViewModel : ObservableObject
    {
        private readonly IInventoryService _inventoryService;

        [ObservableProperty]
        private ObservableCollection<InventoryItem> _inventoryItems;

        public InventoryViewModel(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
            LoadInventoryItems();
        }

        private async void LoadInventoryItems()
        {
            InventoryItems = new ObservableCollection<InventoryItem>(await _inventoryService.GetInventoryItemsAsync());
        }

        [RelayCommand]
        public async void AddInventoryItem(InventoryItem newItem)
        {
            await _inventoryService.AddInventoryItemAsync(newItem);
            LoadInventoryItems();
        }

        [RelayCommand]
        public async void RemoveInventoryItem(InventoryItem item)
        {
            await _inventoryService.RemoveInventoryItemAsync(item);
            LoadInventoryItems();
        }
    }
}