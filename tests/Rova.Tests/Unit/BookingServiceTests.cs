using System;
using System.Threading.Tasks;
using Xunit;
using Rova.Core.Services;
using Rova.Core.Interfaces;
using Rova.Shared.Models;

namespace Rova.Tests.Unit
{
    public class BookingServiceTests
    {
        private readonly IBookingService _bookingService;

        public BookingServiceTests()
        {
            _bookingService = new BookingService(); // Assuming BookingService has a parameterless constructor
        }

        [Fact]
        public async Task BookService_ShouldReturnBookingConfirmation_WhenValidDataProvided()
        {
            // Arrange
            var bookingModel = new BookingModel
            {
                ServiceId = 1,
                CustomerId = 1,
                Date = DateTime.Now.AddDays(1),
                Time = TimeSpan.FromHours(10)
            };

            // Act
            var result = await _bookingService.BookServiceAsync(bookingModel);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Equal("Booking confirmed", result.Message);
        }

        [Fact]
        public async Task BookService_ShouldThrowException_WhenServiceIdIsInvalid()
        {
            // Arrange
            var bookingModel = new BookingModel
            {
                ServiceId = -1, // Invalid ServiceId
                CustomerId = 1,
                Date = DateTime.Now.AddDays(1),
                Time = TimeSpan.FromHours(10)
            };

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() => _bookingService.BookServiceAsync(bookingModel));
        }

        [Fact]
        public async Task GetBookingHistory_ShouldReturnListOfBookings_WhenCustomerIdIsValid()
        {
            // Arrange
            int customerId = 1;

            // Act
            var result = await _bookingService.GetBookingHistoryAsync(customerId);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetBookingHistory_ShouldReturnEmptyList_WhenCustomerIdHasNoBookings()
        {
            // Arrange
            int customerId = 999; // Assuming this customer has no bookings

            // Act
            var result = await _bookingService.GetBookingHistoryAsync(customerId);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
    }
}