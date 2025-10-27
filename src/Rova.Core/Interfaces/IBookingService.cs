using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rova.Shared.Models;

namespace Rova.Core.Interfaces
{
    public interface IBookingService
    {
        Task<BookingDto> CreateBookingAsync(BookingDto booking);
        Task<IEnumerable<BookingDto>> GetBookingsAsync();
        Task<BookingDto> GetBookingByIdAsync(Guid bookingId);
        Task<bool> UpdateBookingAsync(BookingDto booking);
        Task<bool> DeleteBookingAsync(Guid bookingId);
    }
}