using Rova.Shared.Models;

namespace Rova.Core.Interfaces
{
    public interface IInventoryService
    {
        Task<IEnumerable<InventoryItem>> GetAllItemsAsync();
        Task<InventoryItem> GetItemByIdAsync(int id);
        Task AddItemAsync(InventoryItem item);
        Task UpdateItemAsync(InventoryItem item);
        Task DeleteItemAsync(int id);
    }
}