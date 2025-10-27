using Rova.Core.Interfaces;
using Rova.Shared.Models;

namespace Rova.Core.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly List<InventoryItem> _inventoryItems;

        public InventoryService()
        {
            _inventoryItems = new List<InventoryItem>();
        }

        public Task<IEnumerable<InventoryItem>> GetAllItemsAsync()
        {
            return Task.FromResult<IEnumerable<InventoryItem>>(_inventoryItems);
        }

        public Task<InventoryItem> GetItemByIdAsync(int id)
        {
            var item = _inventoryItems.Find(i => i.Id == id);
            return Task.FromResult(item);
        }

        public Task AddItemAsync(InventoryItem item)
        {
            _inventoryItems.Add(item);
            return Task.CompletedTask;
        }

        public Task UpdateItemAsync(InventoryItem item)
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

        public Task DeleteItemAsync(int id)
        {
            var item = _inventoryItems.Find(i => i.Id == id);
            if (item != null)
            {
                _inventoryItems.Remove(item);
            }
            return Task.CompletedTask;
        }
    }
}