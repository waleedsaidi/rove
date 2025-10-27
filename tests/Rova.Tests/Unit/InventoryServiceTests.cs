using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Xunit;
using Rova.Core.Interfaces;
using Rova.Core.Services;
using Rova.Shared.Models;

namespace Rova.Tests.Unit
{
    public class InventoryServiceTests
    {
        private readonly Mock<IInventoryService> _inventoryServiceMock;
        private readonly InventoryService _inventoryService;

        public InventoryServiceTests()
        {
            _inventoryServiceMock = new Mock<IInventoryService>();
            _inventoryService = new InventoryService(_inventoryServiceMock.Object);
        }

        [Fact]
        public async Task GetAllInventoryItems_ShouldReturnListOfItems()
        {
            // Arrange
            var expectedItems = new List<InventoryItem>
            {
                new InventoryItem { Id = 1, Name = "Brake Pads", Quantity = 10 },
                new InventoryItem { Id = 2, Name = "Oil Filter", Quantity = 15 }
            };

            _inventoryServiceMock.Setup(service => service.GetAllInventoryItems()).ReturnsAsync(expectedItems);

            // Act
            var result = await _inventoryService.GetAllInventoryItems();

            // Assert
            Assert.Equal(expectedItems.Count, result.Count);
            Assert.Equal(expectedItems[0].Name, result[0].Name);
        }

        [Fact]
        public async Task AddInventoryItem_ShouldAddItemSuccessfully()
        {
            // Arrange
            var newItem = new InventoryItem { Id = 3, Name = "Air Filter", Quantity = 5 };

            _inventoryServiceMock.Setup(service => service.AddInventoryItem(newItem)).ReturnsAsync(true);

            // Act
            var result = await _inventoryService.AddInventoryItem(newItem);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task UpdateInventoryItem_ShouldUpdateItemSuccessfully()
        {
            // Arrange
            var updatedItem = new InventoryItem { Id = 1, Name = "Brake Pads", Quantity = 12 };

            _inventoryServiceMock.Setup(service => service.UpdateInventoryItem(updatedItem)).ReturnsAsync(true);

            // Act
            var result = await _inventoryService.UpdateInventoryItem(updatedItem);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task DeleteInventoryItem_ShouldDeleteItemSuccessfully()
        {
            // Arrange
            var itemId = 1;

            _inventoryServiceMock.Setup(service => service.DeleteInventoryItem(itemId)).ReturnsAsync(true);

            // Act
            var result = await _inventoryService.DeleteInventoryItem(itemId);

            // Assert
            Assert.True(result);
        }
    }
}