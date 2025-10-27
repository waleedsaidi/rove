using System.Collections.Generic;
using System.Threading.Tasks;
using Rova.Shared.Models;

namespace Rova.Mobile.Services
{
    public class InventoryService
    {
        private readonly List<InventoryItem> _inventoryItems;

        public InventoryService()
        {
            _inventoryItems = new List<InventoryItem>();
        }

        public Task<List<InventoryItem>> GetInventoryItemsAsync()
        {
            return Task.FromResult(_inventoryItems);
        }

        public Task AddInventoryItemAsync(InventoryItem item)
        {
            _inventoryItems.Add(item);
            return Task.CompletedTask;
        }

        public Task UpdateInventoryItemAsync(InventoryItem item)
        {
            var existingItem = _inventoryItems.Find(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Name = item.Name;
                existingItem.Quantity = item.Quantity;
                existingItem.Price = item.Price;
            }
            return Task.CompletedTask;
        }

        public Task RemoveInventoryItemAsync(int itemId)
        {
            var item = _inventoryItems.Find(i => i.Id == itemId);
            if (item != null)
            {
                _inventoryItems.Remove(item);
            }
            return Task.CompletedTask;
        }
    }
}